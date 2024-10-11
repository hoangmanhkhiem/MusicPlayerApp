using System;
using System.IO;
using System.Windows.Forms;
using WMPLib;

namespace MusicPlayerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Load available drives into the comboBox
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    comboBoxDrives.Items.Add(drive.Name);
                }
            }

            // Add event handlers
            comboBoxDrives.SelectedIndexChanged += comboBoxDrives_SelectedIndexChanged;
            comboBoxFolders.SelectedIndexChanged += comboBoxFolders_SelectedIndexChanged;
            listBoxFiles.SelectedIndexChanged += listBoxFiles_SelectedIndexChanged;
        }

        private void comboBoxDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxFolders.Items.Clear();
            string selectedDrive = comboBoxDrives.SelectedItem.ToString();
            string[] directories = Directory.GetDirectories(selectedDrive);

            foreach (string dir in directories)
            {
                comboBoxFolders.Items.Add(dir);
            }
        }

        private void comboBoxFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxFiles.Items.Clear();
            string selectedFolder = comboBoxFolders.SelectedItem.ToString();
            string[] files = Directory.GetFiles(selectedFolder, "*.mp3");

            foreach (string file in files)
            {
                listBoxFiles.Items.Add(Path.GetFileName(file));
            }
        }

        private void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedItem == null)
                return;

            string selectedFolder = comboBoxFolders.SelectedItem.ToString();
            string selectedFile = listBoxFiles.SelectedItem.ToString();
            string fullPath = Path.Combine(selectedFolder, selectedFile);

            // Play the selected file
            windowsMediaPlayer.URL = fullPath;

            // Check for lyrics files
            string lyricsFileTxt = Path.ChangeExtension(fullPath, ".txt");
            string lyricsFileRtf = Path.ChangeExtension(fullPath, ".rtf");

            if (File.Exists(lyricsFileTxt))
            {
                richTextBoxLyrics.LoadFile(lyricsFileTxt, RichTextBoxStreamType.PlainText);
            }
            else if (File.Exists(lyricsFileRtf))
            {
                richTextBoxLyrics.LoadFile(lyricsFileRtf, RichTextBoxStreamType.RichText);
            }
            else
            {
                richTextBoxLyrics.Clear();
                richTextBoxLyrics.Text = "No lyrics available.";
            }
        }
    }
}
