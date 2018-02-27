// Fenix Capture 1.0
// © Ismael Heredia , Argentina , 2018

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Media;
using System.Text.RegularExpressions;

namespace FenixCapture
{
    public partial class FormHome : Form
    {
        string application_title = "";

        string photos_directory = "photos";

        Helpers helper = new Helpers();

        public FormHome()
        {
            InitializeComponent();
        }

        // Imports

        [StructLayout(LayoutKind.Sequential)]
        struct POINTAPI
        {
            public int a;
            public int b;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct CURSORINFO
        {
            public Int32 c;
            public Int32 d;
            public IntPtr e;
            public POINTAPI f;
        }

        [DllImport("user32.dll")]
        static extern bool GetCursorInfo(out CURSORINFO i);

        [DllImport("user32.dll")]
        static extern bool DrawIcon(IntPtr n, int b, int v, IntPtr c);

        // End of imports

        // Functions

        public void get_files()
        {

            lvPhotos.Items.Clear();
            lbData.Items.Clear();

            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
            foreach (string file in files)
            {
                if (Path.GetExtension(file) == ".jpg")
                {
                    lbData.Items.Add(file);
                    FileInfo basename = new FileInfo(file);
                    string name = basename.Name;

                    ListViewItem item = new ListViewItem();
                    item.Text = name;
                    FileInfo info = new FileInfo(name);
                    DateTime creation_datetime = info.CreationTime;
                    item.SubItems.Add(Convert.ToString(creation_datetime));

                    lvPhotos.Items.Add(item);
                }
            }

            gbPhotos.Text = "Photos found [" + lbData.Items.Count + "]";

        }

        public void take_screenshot(string savefile)
        {

            System.Threading.Thread.Sleep(1000);

            try
            {
                Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format24bppRgb);
                Graphics graphics = Graphics.FromImage(bitmap);

                graphics.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);

                CURSORINFO cursorinfo;

                cursorinfo.c = System.Runtime.InteropServices.Marshal.SizeOf(typeof(CURSORINFO));

                if (GetCursorInfo(out cursorinfo))
                {
                    if (cursorinfo.d == 0x00000001)
                    {
                        DrawIcon(graphics.GetHdc(), cursorinfo.f.a, cursorinfo.f.b, cursorinfo.e);
                        graphics.ReleaseHdc();
                    }
                }

                bitmap.Save(savefile);
            }
            catch
            {
                MessageBox.Show("Error taking screenshot", application_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            get_files();

            helper.play_sound("done");
        }

        public string upload_to_imgur(string image)
        {
            string link = "";
            WebClient cliente_web = new WebClient();
            cliente_web.Headers["User-Agent"] = "Opera/9.80 (Windows NT 6.0) Presto/2.12.388 Version/12.14";
            cliente_web.Headers.Add("Authorization", "Client-ID " + "29108b5ec0efcc7");
            System.Collections.Specialized.NameValueCollection parametros = new System.Collections.Specialized.NameValueCollection();
            try
            {
                parametros.Add("image", Convert.ToBase64String(File.ReadAllBytes(image)));
                byte[] respuesta_encode = cliente_web.UploadValues("https://api.imgur.com/3/image", parametros);
                string contenido = Encoding.ASCII.GetString(respuesta_encode).ToString();
                Match regex = Regex.Match(contenido, "\"link\":\"(.*?)\"", RegexOptions.IgnoreCase);
                if (regex.Success)
                {
                    link = regex.Groups[1].Value;
                    link = link.Replace(@"\/", "/");
                }
            }
            catch
            {
                MessageBox.Show("Error uploading image", application_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return link;
        }

        // End of functions

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helper.play_sound("click");

            if (lbData.Items.Count == 0)
            {
                MessageBox.Show("File not found", application_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string fullpath = lbData.Items[lvPhotos.FocusedItem.Index].ToString();
                System.Diagnostics.Process.Start(fullpath);
            }
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fullpath = Directory.GetCurrentDirectory();
            System.Diagnostics.Process.Start(fullpath);
        }

        private void btnTakeScreenshot_Click(object sender, EventArgs e)
        {
            helper.play_sound("click");

            string image_name = "";

            if (rbSaveWithThisName.Checked)
            {
                image_name = txtThisName.Text;
            }

            if (rbSaveWithDataName.Checked)
            {
                image_name = Convert.ToString(DateTime.Now) + ".jpg";
                image_name = image_name.Replace("/", "_");
                image_name = image_name.Replace(":", "_");
                image_name = image_name.Replace(" ", "_");
            }

            if (cbTakeScreenshots.Checked)
            {
                if (txtSeconds.Text == "")
                {
                    txtSeconds.Text = "0";
                }
                for (int i = Convert.ToInt32(txtSeconds.Text); i > 0; i--)
                {
                    status.Text = "[+] Taking screen in " + i + " seconds ..";
                    this.Refresh();
                    System.Threading.Thread.Sleep(i * 1000);
                }
            }

            this.Hide();
            take_screenshot(image_name);
            this.Show();

            if (cbUploadToImgur.Checked)
            {
                status.Text = "[+] Uploading image to imgur ..";
                this.Refresh();
                string link = upload_to_imgur(image_name);
                status.Text = "[+] Opening url image in default browser ..";
                this.Refresh();
                System.Diagnostics.Process.Start(link);
            }

            status.Text = "[+] Done";
            this.Refresh();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(photos_directory))
            {
                System.IO.Directory.CreateDirectory(photos_directory);
                Directory.SetCurrentDirectory(photos_directory);
            }
            else
            {
                Directory.SetCurrentDirectory(photos_directory);
            }

            get_files();

            helper.play_sound("loaded");
        }

        private void FormHome_MouseClick(object sender, MouseEventArgs e)
        {
            helper.play_sound("click");
        }
    }
}
