namespace FenixCapture
{
    partial class FormHome
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.tcPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnTakeScreenshot = new System.Windows.Forms.Button();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.cbTakeScreenshots = new System.Windows.Forms.CheckBox();
            this.txtThisName = new System.Windows.Forms.TextBox();
            this.rbSaveWithDataName = new System.Windows.Forms.RadioButton();
            this.rbSaveWithThisName = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnFindWindow = new System.Windows.Forms.Button();
            this.gbHelp = new System.Windows.Forms.GroupBox();
            this.lblHelp = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnTakeScreenshotProcess = new System.Windows.Forms.Button();
            this.gbProcessFound = new System.Windows.Forms.GroupBox();
            this.lvProcess = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gbPhotos = new System.Windows.Forms.GroupBox();
            this.lbData = new System.Windows.Forms.ListBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.gbAbout = new System.Windows.Forms.GroupBox();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.take_window = new System.Windows.Forms.Timer(this.components);
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tcPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbHelp.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.gbProcessFound.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.gbPhotos.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.gbAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Controls.Add(this.tabPage1);
            this.tcPrincipal.Controls.Add(this.tabPage2);
            this.tcPrincipal.Controls.Add(this.tabPage3);
            this.tcPrincipal.Controls.Add(this.tabPage4);
            this.tcPrincipal.Controls.Add(this.tabPage5);
            this.tcPrincipal.Location = new System.Drawing.Point(12, 113);
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(327, 272);
            this.tcPrincipal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnTakeScreenshot);
            this.tabPage1.Controls.Add(this.gbOptions);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(319, 246);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Full Screen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnTakeScreenshot
            // 
            this.btnTakeScreenshot.Location = new System.Drawing.Point(80, 153);
            this.btnTakeScreenshot.Name = "btnTakeScreenshot";
            this.btnTakeScreenshot.Size = new System.Drawing.Size(158, 23);
            this.btnTakeScreenshot.TabIndex = 1;
            this.btnTakeScreenshot.Text = "Take Screenshot";
            this.btnTakeScreenshot.UseVisualStyleBackColor = true;
            this.btnTakeScreenshot.Click += new System.EventHandler(this.btnTakeScreenshot_Click);
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.lblSeconds);
            this.gbOptions.Controls.Add(this.txtSeconds);
            this.gbOptions.Controls.Add(this.cbTakeScreenshots);
            this.gbOptions.Controls.Add(this.txtThisName);
            this.gbOptions.Controls.Add(this.rbSaveWithDataName);
            this.gbOptions.Controls.Add(this.rbSaveWithThisName);
            this.gbOptions.Location = new System.Drawing.Point(20, 22);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(281, 111);
            this.gbOptions.TabIndex = 0;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(182, 76);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(47, 13);
            this.lblSeconds.TabIndex = 5;
            this.lblSeconds.Text = "seconds";
            // 
            // txtSeconds
            // 
            this.txtSeconds.Location = new System.Drawing.Point(132, 76);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(44, 20);
            this.txtSeconds.TabIndex = 4;
            this.txtSeconds.Text = "3";
            // 
            // cbTakeScreenshots
            // 
            this.cbTakeScreenshots.AutoSize = true;
            this.cbTakeScreenshots.Location = new System.Drawing.Point(17, 76);
            this.cbTakeScreenshots.Name = "cbTakeScreenshots";
            this.cbTakeScreenshots.Size = new System.Drawing.Size(120, 17);
            this.cbTakeScreenshots.TabIndex = 3;
            this.cbTakeScreenshots.Text = "Take screenshot in ";
            this.cbTakeScreenshots.UseVisualStyleBackColor = true;
            // 
            // txtThisName
            // 
            this.txtThisName.Location = new System.Drawing.Point(142, 29);
            this.txtThisName.Name = "txtThisName";
            this.txtThisName.Size = new System.Drawing.Size(119, 20);
            this.txtThisName.TabIndex = 2;
            // 
            // rbSaveWithDataName
            // 
            this.rbSaveWithDataName.AutoSize = true;
            this.rbSaveWithDataName.Checked = true;
            this.rbSaveWithDataName.Location = new System.Drawing.Point(17, 53);
            this.rbSaveWithDataName.Name = "rbSaveWithDataName";
            this.rbSaveWithDataName.Size = new System.Drawing.Size(125, 17);
            this.rbSaveWithDataName.TabIndex = 1;
            this.rbSaveWithDataName.TabStop = true;
            this.rbSaveWithDataName.Text = "Save with date name";
            this.rbSaveWithDataName.UseVisualStyleBackColor = true;
            // 
            // rbSaveWithThisName
            // 
            this.rbSaveWithThisName.AutoSize = true;
            this.rbSaveWithThisName.Location = new System.Drawing.Point(17, 29);
            this.rbSaveWithThisName.Name = "rbSaveWithThisName";
            this.rbSaveWithThisName.Size = new System.Drawing.Size(129, 17);
            this.rbSaveWithThisName.TabIndex = 0;
            this.rbSaveWithThisName.Text = "Save with this name : ";
            this.rbSaveWithThisName.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnStop);
            this.tabPage2.Controls.Add(this.btnFindWindow);
            this.tabPage2.Controls.Add(this.gbHelp);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(319, 246);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Active Window";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(84, 139);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(153, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnFindWindow
            // 
            this.btnFindWindow.Location = new System.Drawing.Point(84, 109);
            this.btnFindWindow.Name = "btnFindWindow";
            this.btnFindWindow.Size = new System.Drawing.Size(153, 23);
            this.btnFindWindow.TabIndex = 1;
            this.btnFindWindow.Text = "Find Window";
            this.btnFindWindow.UseVisualStyleBackColor = true;
            this.btnFindWindow.Click += new System.EventHandler(this.btnFindWindow_Click);
            // 
            // gbHelp
            // 
            this.gbHelp.Controls.Add(this.lblHelp);
            this.gbHelp.Location = new System.Drawing.Point(29, 19);
            this.gbHelp.Name = "gbHelp";
            this.gbHelp.Size = new System.Drawing.Size(264, 67);
            this.gbHelp.TabIndex = 0;
            this.gbHelp.TabStop = false;
            this.gbHelp.Text = "Help";
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Location = new System.Drawing.Point(23, 30);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(217, 13);
            this.lblHelp.TabIndex = 0;
            this.lblHelp.Text = "Use shift+t to take screenshot of the window";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnTakeScreenshotProcess);
            this.tabPage3.Controls.Add(this.gbProcessFound);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(319, 246);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Process";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnTakeScreenshotProcess
            // 
            this.btnTakeScreenshotProcess.Location = new System.Drawing.Point(84, 195);
            this.btnTakeScreenshotProcess.Name = "btnTakeScreenshotProcess";
            this.btnTakeScreenshotProcess.Size = new System.Drawing.Size(150, 23);
            this.btnTakeScreenshotProcess.TabIndex = 1;
            this.btnTakeScreenshotProcess.Text = "Take ScreenShot";
            this.btnTakeScreenshotProcess.UseVisualStyleBackColor = true;
            this.btnTakeScreenshotProcess.Click += new System.EventHandler(this.btnTakeScreenshotProcess_Click);
            // 
            // gbProcessFound
            // 
            this.gbProcessFound.Controls.Add(this.lvProcess);
            this.gbProcessFound.Location = new System.Drawing.Point(21, 20);
            this.gbProcessFound.Name = "gbProcessFound";
            this.gbProcessFound.Size = new System.Drawing.Size(276, 156);
            this.gbProcessFound.TabIndex = 0;
            this.gbProcessFound.TabStop = false;
            this.gbProcessFound.Text = "Process Found";
            // 
            // lvProcess
            // 
            this.lvProcess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvProcess.ContextMenuStrip = this.contextMenuStrip1;
            this.lvProcess.FullRowSelect = true;
            this.lvProcess.Location = new System.Drawing.Point(19, 28);
            this.lvProcess.Name = "lvProcess";
            this.lvProcess.Size = new System.Drawing.Size(238, 111);
            this.lvProcess.TabIndex = 0;
            this.lvProcess.UseCompatibleStateImageBehavior = false;
            this.lvProcess.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 174;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 26);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.gbPhotos);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(319, 246);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Photos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // gbPhotos
            // 
            this.gbPhotos.Controls.Add(this.lbData);
            this.gbPhotos.Controls.Add(this.listView2);
            this.gbPhotos.Location = new System.Drawing.Point(17, 21);
            this.gbPhotos.Name = "gbPhotos";
            this.gbPhotos.Size = new System.Drawing.Size(277, 191);
            this.gbPhotos.TabIndex = 0;
            this.gbPhotos.TabStop = false;
            this.gbPhotos.Text = "Photos";
            // 
            // lbData
            // 
            this.lbData.FormattingEnabled = true;
            this.lbData.Location = new System.Drawing.Point(140, 63);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(120, 95);
            this.lbData.TabIndex = 1;
            this.lbData.Visible = false;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.ContextMenuStrip = this.contextMenuStrip2;
            this.listView2.FullRowSelect = true;
            this.listView2.Location = new System.Drawing.Point(18, 29);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(242, 141);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 122;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date";
            this.columnHeader4.Width = 116;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openFolderToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(140, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openFolderToolStripMenuItem.Text = "Open Folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.gbAbout);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(319, 246);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "About";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // gbAbout
            // 
            this.gbAbout.Controls.Add(this.lblCopyRight);
            this.gbAbout.Controls.Add(this.pbImg);
            this.gbAbout.Location = new System.Drawing.Point(15, 21);
            this.gbAbout.Name = "gbAbout";
            this.gbAbout.Size = new System.Drawing.Size(279, 210);
            this.gbAbout.TabIndex = 0;
            this.gbAbout.TabStop = false;
            this.gbAbout.Text = "About";
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Location = new System.Drawing.Point(51, 179);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(176, 13);
            this.lblCopyRight.TabIndex = 1;
            this.lblCopyRight.Text = "© Ismael Heredia , Argentina , 2016";
            // 
            // pbImg
            // 
            this.pbImg.Image = ((System.Drawing.Image)(resources.GetObject("pbImg.Image")));
            this.pbImg.Location = new System.Drawing.Point(52, 19);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(175, 149);
            this.pbImg.TabIndex = 0;
            this.pbImg.TabStop = false;
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.StatusStrip.Location = new System.Drawing.Point(0, 396);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(352, 22);
            this.StatusStrip.TabIndex = 1;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(58, 17);
            this.status.Text = "[+] Ready";
            // 
            // take_window
            // 
            this.take_window.Tick += new System.EventHandler(this.take_window_Tick);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(16, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(310, 80);
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 418);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.tcPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.Text = " - Fenix Capture 0.6 - © Ismael Heredia , Argentina , 2016";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHome_FormClosing);
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.tcPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.gbHelp.ResumeLayout(false);
            this.gbHelp.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.gbProcessFound.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.gbPhotos.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.gbAbout.ResumeLayout(false);
            this.gbAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.TextBox txtThisName;
        private System.Windows.Forms.RadioButton rbSaveWithDataName;
        private System.Windows.Forms.RadioButton rbSaveWithThisName;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.CheckBox cbTakeScreenshots;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.GroupBox gbHelp;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.GroupBox gbProcessFound;
        private System.Windows.Forms.Button btnTakeScreenshot;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnFindWindow;
        private System.Windows.Forms.Button btnTakeScreenshotProcess;
        private System.Windows.Forms.Timer take_window;
        private System.Windows.Forms.ListView lvProcess;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbPhotos;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListBox lbData;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox gbAbout;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Label lblCopyRight;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;

    }
}

