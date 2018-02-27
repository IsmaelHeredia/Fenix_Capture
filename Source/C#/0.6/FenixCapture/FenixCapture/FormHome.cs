// Fenix Capture 0.6
// © Ismael Heredia , Argentina , 2016

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
using System.IO;
using System.Media;

namespace FenixCapture
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(Keys k1);
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(Int32 k2);
        [DllImport("user32.dll")]
        private static extern short GetKeyState(Keys k3);
        [DllImport("user32.dll")]
        private static extern short GetKeyState(Int32 k4);

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

        //

        [StructLayout(LayoutKind.Sequential)]
        public struct Rect
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowRect(IntPtr l, ref Rect k);

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr j);

        private class User32
        {
            [StructLayout(LayoutKind.Sequential)]
            public struct Rect
            {
                public int left;
                public int top;
                public int right;
                public int bottom;
            }

            [DllImport("user32.dll")]
            public static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);
        }

        //

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        public void get_files()
        {

            listView2.Items.Clear();
            lbData.Items.Clear();

            string[] archivos = Directory.GetFiles(Directory.GetCurrentDirectory());
            foreach (string archivo in archivos)
            {
                if (Path.GetExtension(archivo) == ".jpg")
                {
                    lbData.Items.Add(archivo);
                    FileInfo basename = new FileInfo(archivo);
                    string nombre = basename.Name;

                    ListViewItem agregar = new ListViewItem();
                    agregar.Text = nombre;
                    FileInfo info = new FileInfo(nombre);
                    DateTime cuando = info.CreationTime;
                    agregar.SubItems.Add(Convert.ToString(cuando));

                    listView2.Items.Add(agregar);
                }
            }

            gbPhotos.Text = "Photos found [" + lbData.Items.Count + "]";

        }

        public void get_process()
        {
            lvProcess.Items.Clear();

            Process[] procesos = Process.GetProcesses();

            foreach (Process proceso in procesos)
            {

                ListViewItem item = new ListViewItem();

                item.Text = Convert.ToString(proceso.Id);
                item.SubItems.Add(Convert.ToString(proceso.ProcessName));
                lvProcess.Items.Add(item);

            }

            gbProcessFound.Text = "Process Found :  [" + Convert.ToString(lvProcess.Items.Count) + "]";

        }

        public void capturar_ventana(string nombre_proceso)
        {
            string nombre = "";

            if (rbSaveWithThisName.Checked)
            {
                nombre = txtThisName.Text;
            }

            if (rbSaveWithDataName.Checked)
            {
                nombre = Convert.ToString(DateTime.Now) + ".jpg";
                nombre = nombre.Replace("/", "_");
                nombre = nombre.Replace(":", "_");
                nombre = nombre.Replace(" ", "_");
            }

            try
            {
                bool found = false;

                Process[] procs = Process.GetProcessesByName(nombre_proceso);

                var rect = new User32.Rect();

                int width;
                int height;

                foreach (Process proc in procs)
                {
                    User32.GetWindowRect(proc.MainWindowHandle, ref rect);

                    width = rect.right - rect.left;
                    height = rect.bottom - rect.top;

                    if (width != 0 && height != 0)
                    {
                        System.Threading.Thread.Sleep(1000);

                        var bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);
                        Graphics graphics = Graphics.FromImage(bmp);
                        graphics.CopyFromScreen(rect.left, rect.top, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);

                        bmp.Save(nombre, ImageFormat.Jpeg);

                        found = true;

                        break;
                    }
                }
                if (found)
                {
                    SetForegroundWindow(this.Handle);

                    SoundPlayer sound = new SoundPlayer(FenixCapture.Properties.Resources.scanfin);
                    sound.Play();

                    status.Text = "[+] Screenshot Taked";
                    this.Refresh();

                    MessageBox.Show("Photo Taked");
                }
                else
                {
                    MessageBox.Show("Window not found");
                }
            }
            catch
            {
                //
            }

            get_files();

            if (take_window.Enabled == true)
            {
                take_window.Enabled = false;
            }
        }


        public void take_screen(string file)
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

                bitmap.Save(file);
            }
            catch
            {
                //
            }

            get_files();

            SoundPlayer sound = new SoundPlayer(FenixCapture.Properties.Resources.scanfin);
            sound.Play();
        }

        private void take_window_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 255; i++)
            {
                int n = GetAsyncKeyState(i);
                if (n == -32767)
                {
                    if (i >= 65 && i <= 122)
                    {
                        if (Convert.ToBoolean(GetAsyncKeyState(Keys.ShiftKey)))
                        {
                            if (Convert.ToChar(i).ToString() == "T")
                            {
                                capturar_ventana(get_ventana_actual());
                            }
                        }
                    }
                }
            }
        }

        public string get_ventana_actual()
        {
            string casi = "";
            uint identificacion;
            try
            {
                GetWindowThreadProcessId(GetForegroundWindow(), out identificacion);
                casi = Path.GetFileName(Process.GetProcessById(Convert.ToInt32(identificacion)).MainModule.FileName);
                casi = casi.Replace(Path.GetExtension(casi), "");
            }
            catch
            {
                //
            }
            return casi;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            get_process();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(FenixCapture.Properties.Resources.click);
            sound.Play();

            if (lbData.Items.Count == 0)
            {
                MessageBox.Show("Error");
            }
            else
            {
                string ponecarajo = lbData.Items[listView2.FocusedItem.Index].ToString();
                System.Diagnostics.Process.Start(ponecarajo);
            }
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fullpath = Directory.GetCurrentDirectory();
            System.Diagnostics.Process.Start(fullpath);
        }

        private void btnTakeScreenshot_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(FenixCapture.Properties.Resources.click);
            sound.Play();

            string nombre = "";

            if (rbSaveWithThisName.Checked)
            {
                nombre = txtThisName.Text;
            }

            if (rbSaveWithDataName.Checked)
            {
                nombre = Convert.ToString(DateTime.Now) + ".jpg";
                nombre = nombre.Replace("/", "_");
                nombre = nombre.Replace(":", "_");
                nombre = nombre.Replace(" ", "_");
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
            take_screen(nombre);
            this.Show();

            status.Text = "[+] Done";
            this.Refresh();
        }

        private void btnFindWindow_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(FenixCapture.Properties.Resources.click);
            sound.Play();
            status.Text = "[+] Finding Window ...";
            this.Refresh();
            take_window.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(FenixCapture.Properties.Resources.click);
            sound.Play();
            status.Text = "[+] Ready";
            this.Refresh();
            take_window.Enabled = false;
        }

        private void btnTakeScreenshotProcess_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(FenixCapture.Properties.Resources.click);
            sound.Play();
            if (lvProcess.FocusedItem.SubItems[1].Text != "")
            {
                Process[] focus = Process.GetProcessesByName(lvProcess.FocusedItem.SubItems[1].Text);
                SetForegroundWindow(focus[0].MainWindowHandle);
                capturar_ventana(lvProcess.FocusedItem.SubItems[1].Text);
                this.Focus();
            }
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("photos"))
            {
                System.IO.Directory.CreateDirectory("photos");
                Directory.SetCurrentDirectory("photos");
            }
            else
            {
                Directory.SetCurrentDirectory("photos");
            }

            get_files();

            get_process();

            SoundPlayer sound = new SoundPlayer(FenixCapture.Properties.Resources.formcreate);
            sound.Play();
        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            take_window.Enabled = false;
        }
    }
}
