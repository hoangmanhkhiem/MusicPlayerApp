namespace MusicPlayerApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxDrives;
        private System.Windows.Forms.ComboBox comboBoxFolders;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.RichTextBox richTextBoxLyrics;
        private AxWMPLib.AxWindowsMediaPlayer windowsMediaPlayer;
        private System.Windows.Forms.Label labelDrive;
        private System.Windows.Forms.Label labelFolder;
        private System.Windows.Forms.Label labelFiles;
        private System.Windows.Forms.Label labelLyrics;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxDrives = new System.Windows.Forms.ComboBox();
            this.comboBoxFolders = new System.Windows.Forms.ComboBox();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.richTextBoxLyrics = new System.Windows.Forms.RichTextBox();
            this.windowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.labelDrive = new System.Windows.Forms.Label();
            this.labelFolder = new System.Windows.Forms.Label();
            this.labelFiles = new System.Windows.Forms.Label();
            this.labelLyrics = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayer)).BeginInit();
            this.SuspendLayout();

            // comboBoxDrives
            this.comboBoxDrives.Location = new System.Drawing.Point(12, 30);
            this.comboBoxDrives.Name = "comboBoxDrives";
            this.comboBoxDrives.Size = new System.Drawing.Size(200, 24);
            this.comboBoxDrives.TabIndex = 0;

            // comboBoxFolders
            this.comboBoxFolders.Location = new System.Drawing.Point(12, 80);
            this.comboBoxFolders.Name = "comboBoxFolders";
            this.comboBoxFolders.Size = new System.Drawing.Size(200, 24);
            this.comboBoxFolders.TabIndex = 1;

            // listBoxFiles
            this.listBoxFiles.Location = new System.Drawing.Point(12, 130);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(200, 150);
            this.listBoxFiles.TabIndex = 2;

            // richTextBoxLyrics
            this.richTextBoxLyrics.Location = new System.Drawing.Point(230, 30);
            this.richTextBoxLyrics.Name = "richTextBoxLyrics";
            this.richTextBoxLyrics.Size = new System.Drawing.Size(300, 250);
            this.richTextBoxLyrics.TabIndex = 3;

            // windowsMediaPlayer
            this.windowsMediaPlayer.Enabled = true;
            this.windowsMediaPlayer.Location = new System.Drawing.Point(12, 300);
            this.windowsMediaPlayer.Name = "windowsMediaPlayer";
            this.windowsMediaPlayer.Size = new System.Drawing.Size(518, 45);
            this.windowsMediaPlayer.TabIndex = 4;
            this.windowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(new System.ComponentModel.ComponentResourceManager(typeof(Form1)).GetObject("windowsMediaPlayer.OcxState")));

            // labelDrive
            this.labelDrive.AutoSize = true;
            this.labelDrive.Location = new System.Drawing.Point(12, 10);
            this.labelDrive.Name = "labelDrive";
            this.labelDrive.Size = new System.Drawing.Size(80, 17);
            this.labelDrive.TabIndex = 5;
            this.labelDrive.Text = "Select Drive:";

            // labelFolder
            this.labelFolder.AutoSize = true;
            this.labelFolder.Location = new System.Drawing.Point(12, 60);
            this.labelFolder.Name = "labelFolder";
            this.labelFolder.Size = new System.Drawing.Size(88, 17);
            this.labelFolder.TabIndex = 6;
            this.labelFolder.Text = "Select Folder:";

            // labelFiles
            this.labelFiles.AutoSize = true;
            this.labelFiles.Location = new System.Drawing.Point(12, 110);
            this.labelFiles.Name = "labelFiles";
            this.labelFiles.Size = new System.Drawing.Size(72, 17);
            this.labelFiles.TabIndex = 7;
            this.labelFiles.Text = "Music Files:";

            // labelLyrics
            this.labelLyrics.AutoSize = true;
            this.labelLyrics.Location = new System.Drawing.Point(230, 10);
            this.labelLyrics.Name = "labelLyrics";
            this.labelLyrics.Size = new System.Drawing.Size(46, 17);
            this.labelLyrics.TabIndex = 8;
            this.labelLyrics.Text = "Lyrics:";

            // Form1
            this.ClientSize = new System.Drawing.Size(550, 360);
            this.Controls.Add(this.labelDrive);
            this.Controls.Add(this.labelFolder);
            this.Controls.Add(this.labelFiles);
            this.Controls.Add(this.labelLyrics);
            this.Controls.Add(this.comboBoxDrives);
            this.Controls.Add(this.comboBoxFolders);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.richTextBoxLyrics);
            this.Controls.Add(this.windowsMediaPlayer);
            this.Name = "Form1";
            this.Text = "Music Player";

            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
