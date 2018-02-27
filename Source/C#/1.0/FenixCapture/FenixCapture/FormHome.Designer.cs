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
            this.tpScreenshoter = new System.Windows.Forms.TabPage();
            this.btnTakeScreenshot = new System.Windows.Forms.Button();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.cbUploadToImgur = new System.Windows.Forms.CheckBox();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.cbTakeScreenshots = new System.Windows.Forms.CheckBox();
            this.txtThisName = new System.Windows.Forms.TextBox();
            this.rbSaveWithDataName = new System.Windows.Forms.RadioButton();
            this.rbSaveWithThisName = new System.Windows.Forms.RadioButton();
            this.tpPhotos = new System.Windows.Forms.TabPage();
            this.gbPhotos = new System.Windows.Forms.GroupBox();
            this.lbData = new System.Windows.Forms.ListBox();
            this.lvPhotos = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpAbout = new System.Windows.Forms.TabPage();
            this.gbAbout = new System.Windows.Forms.GroupBox();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tcPrincipal.SuspendLayout();
            this.tpScreenshoter.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.tpPhotos.SuspendLayout();
            this.gbPhotos.SuspendLayout();
            this.cmsOptions.SuspendLayout();
            this.tpAbout.SuspendLayout();
            this.gbAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.ssStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Controls.Add(this.tpScreenshoter);
            this.tcPrincipal.Controls.Add(this.tpPhotos);
            this.tcPrincipal.Controls.Add(this.tpAbout);
            this.tcPrincipal.Location = new System.Drawing.Point(12, 113);
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(327, 272);
            this.tcPrincipal.TabIndex = 0;
            // 
            // tpScreenshoter
            // 
            this.tpScreenshoter.Controls.Add(this.btnTakeScreenshot);
            this.tpScreenshoter.Controls.Add(this.gbOptions);
            this.tpScreenshoter.Location = new System.Drawing.Point(4, 22);
            this.tpScreenshoter.Name = "tpScreenshoter";
            this.tpScreenshoter.Padding = new System.Windows.Forms.Padding(3);
            this.tpScreenshoter.Size = new System.Drawing.Size(319, 246);
            this.tpScreenshoter.TabIndex = 0;
            this.tpScreenshoter.Text = "Full Screen";
            this.tpScreenshoter.UseVisualStyleBackColor = true;
            // 
            // btnTakeScreenshot
            // 
            this.btnTakeScreenshot.Location = new System.Drawing.Point(78, 179);
            this.btnTakeScreenshot.Name = "btnTakeScreenshot";
            this.btnTakeScreenshot.Size = new System.Drawing.Size(158, 23);
            this.btnTakeScreenshot.TabIndex = 1;
            this.btnTakeScreenshot.Text = "Take Screenshot";
            this.btnTakeScreenshot.UseVisualStyleBackColor = true;
            this.btnTakeScreenshot.Click += new System.EventHandler(this.btnTakeScreenshot_Click);
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.cbUploadToImgur);
            this.gbOptions.Controls.Add(this.lblSeconds);
            this.gbOptions.Controls.Add(this.txtSeconds);
            this.gbOptions.Controls.Add(this.cbTakeScreenshots);
            this.gbOptions.Controls.Add(this.txtThisName);
            this.gbOptions.Controls.Add(this.rbSaveWithDataName);
            this.gbOptions.Controls.Add(this.rbSaveWithThisName);
            this.gbOptions.Location = new System.Drawing.Point(20, 22);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(281, 132);
            this.gbOptions.TabIndex = 0;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // cbUploadToImgur
            // 
            this.cbUploadToImgur.AutoSize = true;
            this.cbUploadToImgur.Location = new System.Drawing.Point(17, 99);
            this.cbUploadToImgur.Name = "cbUploadToImgur";
            this.cbUploadToImgur.Size = new System.Drawing.Size(100, 17);
            this.cbUploadToImgur.TabIndex = 6;
            this.cbUploadToImgur.Text = "Upload to imgur";
            this.cbUploadToImgur.UseVisualStyleBackColor = true;
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
            // tpPhotos
            // 
            this.tpPhotos.Controls.Add(this.gbPhotos);
            this.tpPhotos.Location = new System.Drawing.Point(4, 22);
            this.tpPhotos.Name = "tpPhotos";
            this.tpPhotos.Size = new System.Drawing.Size(319, 246);
            this.tpPhotos.TabIndex = 3;
            this.tpPhotos.Text = "Photos";
            this.tpPhotos.UseVisualStyleBackColor = true;
            // 
            // gbPhotos
            // 
            this.gbPhotos.Controls.Add(this.lbData);
            this.gbPhotos.Controls.Add(this.lvPhotos);
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
            // lvPhotos
            // 
            this.lvPhotos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvPhotos.ContextMenuStrip = this.cmsOptions;
            this.lvPhotos.FullRowSelect = true;
            this.lvPhotos.Location = new System.Drawing.Point(18, 29);
            this.lvPhotos.Name = "lvPhotos";
            this.lvPhotos.Size = new System.Drawing.Size(242, 141);
            this.lvPhotos.TabIndex = 0;
            this.lvPhotos.UseCompatibleStateImageBehavior = false;
            this.lvPhotos.View = System.Windows.Forms.View.Details;
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
            // cmsOptions
            // 
            this.cmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openFolderToolStripMenuItem});
            this.cmsOptions.Name = "contextMenuStrip2";
            this.cmsOptions.Size = new System.Drawing.Size(140, 48);
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
            // tpAbout
            // 
            this.tpAbout.Controls.Add(this.gbAbout);
            this.tpAbout.Location = new System.Drawing.Point(4, 22);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Size = new System.Drawing.Size(319, 246);
            this.tpAbout.TabIndex = 4;
            this.tpAbout.Text = "About";
            this.tpAbout.UseVisualStyleBackColor = true;
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
            this.lblCopyRight.Text = "© Ismael Heredia , Argentina , 2018";
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
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.ssStatus.Location = new System.Drawing.Point(0, 396);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(352, 22);
            this.ssStatus.TabIndex = 1;
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(58, 17);
            this.status.Text = "[+] Ready";
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
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.tcPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormHome";
            this.Text = " - Fenix Capture 1.0 - © Ismael Heredia , Argentina , 2018";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormHome_MouseClick);
            this.tcPrincipal.ResumeLayout(false);
            this.tpScreenshoter.ResumeLayout(false);
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.tpPhotos.ResumeLayout(false);
            this.gbPhotos.ResumeLayout(false);
            this.cmsOptions.ResumeLayout(false);
            this.tpAbout.ResumeLayout(false);
            this.gbAbout.ResumeLayout(false);
            this.gbAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcPrincipal;
        private System.Windows.Forms.TabPage tpScreenshoter;
        private System.Windows.Forms.TabPage tpPhotos;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.TextBox txtThisName;
        private System.Windows.Forms.RadioButton rbSaveWithDataName;
        private System.Windows.Forms.RadioButton rbSaveWithThisName;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.CheckBox cbTakeScreenshots;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.Button btnTakeScreenshot;
        private System.Windows.Forms.GroupBox gbPhotos;
        private System.Windows.Forms.ListView lvPhotos;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListBox lbData;
        private System.Windows.Forms.ContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TabPage tpAbout;
        private System.Windows.Forms.GroupBox gbAbout;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Label lblCopyRight;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbUploadToImgur;

    }
}

