using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace Zippi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Zipper";
        }

        private void plikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "All files (*.*)|*.*";
                dialog.FilterIndex = 1;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(dialog.FileName) == ".zip")
                    {
                        richTextBox1.AppendText("Selected file is a zip file. Please choose a different file.\n");
                        return;
                    }

                    var fileToZipPath = dialog.FileName;
                    var zipFileName = Path.GetFileNameWithoutExtension(fileToZipPath) + ".zip";
                    var zipFileDir = Path.GetDirectoryName(fileToZipPath);

                    var existingZipFiles = Directory.GetFiles(zipFileDir, zipFileName);
                    if (existingZipFiles.Length > 0)
                    {
                        richTextBox1.AppendText("File already zipped! Please select a different file.\n");
                        return;
                    }

                    var destinationPath = Path.Combine(zipFileDir, zipFileName);

                    using (var zipArchive = ZipFile.Open(destinationPath, ZipArchiveMode.Create))
                    {
                        zipArchive.CreateEntryFromFile(fileToZipPath, Path.GetFileName(fileToZipPath));
                    }

                    richTextBox1.AppendText($"File {Path.GetFileName(destinationPath)} zipped to {destinationPath}\n");
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void folderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var folderToZipPath = dialog.SelectedPath;
                    var zipFileName = Path.GetFileName(folderToZipPath) + ".zip";
                    var zipFileDir = Path.GetDirectoryName(folderToZipPath);

                    var existingZipFiles = Directory.GetFiles(zipFileDir, zipFileName);
                    if (existingZipFiles.Length > 0)
                    {
                        richTextBox1.AppendText("File already zipped! Please select a different file.\n");
                        return;
                    }

                    var destinationPath = Path.Combine(zipFileDir, zipFileName);

                    using (var zipArchive = ZipFile.Open(destinationPath, ZipArchiveMode.Create))
                    {
                        foreach (var file in Directory.GetFiles(folderToZipPath))
                        {
                            zipArchive.CreateEntryFromFile(file, Path.GetFileName(file));
                        }
                    }

                    richTextBox1.AppendText($"Folder {Path.GetFileName(folderToZipPath)} zipped to {destinationPath}\n");
                }
            }
        }


        private void rozpakujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "Zip files (*.zip)|*.zip";
                dialog.Title = "Select a zip file to unzip";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var zipFilePath = dialog.FileName;
                    var zipFileName = Path.GetFileNameWithoutExtension(zipFilePath);
                    var zipFileDir = Path.GetDirectoryName(zipFilePath);

                    var destinationPath = Path.Combine(zipFileDir, zipFileName);

                    if (Directory.Exists(destinationPath))
                    {
                        richTextBox1.AppendText("Destination folder already exists! Please select a different folder.\n");
                        return;
                    }

                    ZipFile.ExtractToDirectory(zipFilePath, destinationPath);
                    richTextBox1.AppendText($"Zip file {Path.GetFileName(zipFilePath)} extracted to {destinationPath}\n");
                }
            }
        }
    }
}
