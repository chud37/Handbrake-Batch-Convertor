using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Threading;

namespace Handbrake_Batch_Creator
{
    public partial class Form1 : Form
    {

        string outputFileName = "handbrake";

        public Form1()
        {
            InitializeComponent();

            sourceDIR.Text = Properties.Settings.Default.source_directory;
            destinationDIR.Text = Properties.Settings.Default.destination_directory;
            numericNumberOfFiles.Value = Properties.Settings.Default.number_of_files;
            comboAspectRatio.SelectedIndex = 0;
            comboFileTypes.SelectedIndex = 0;

            toolStripStatusLabel.Text = "Ready";

        }

        private void buttonCreateFiles_Click(object sender, EventArgs e)
        {
            string blankQueueTask = Properties.Resources.queuetask.ToString();

            // https://stackoverflow.com/a/54213859/1445985
            var comboValues = comboFileTypes.Items.Cast<string>();
            var files = Directory.EnumerateFiles(sourceDIR.Text, "*.*", SearchOption.AllDirectories).Where(s => comboValues.Any(v => s.EndsWith(v, StringComparison.OrdinalIgnoreCase)));

            string desktopDIR = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            int numberOfFiles = (int)numericNumberOfFiles.Value;
            int fileCount = files.Count() - 1;
            int itemsInEachFile = (fileCount / numberOfFiles); // 98
            int remainder = (fileCount % numberOfFiles); // 1

            toolStripStatusLabel.Text = fileCount.ToString() + " files found.";
            toolStripProgressBar.Maximum = files.Count();
            toolStripProgressBar.Visible = true;

            SortedList<int, List<string>> outputFiles = new SortedList<int, List<string>>();

            for (int i = 1; i <= numberOfFiles; i++)
            {
                List<string> tmpList = new List<string>();
                for (int x = ((i - 1) * itemsInEachFile + (i > 1 ? 1 : 0)); x <= (itemsInEachFile * i) + (i == numberOfFiles ? remainder : 0); x++)
                {
                    tmpList.Add(files.ElementAt(x));
                }
                outputFiles.Add(i, tmpList);
            }

            foreach (KeyValuePair<int, List<string>> outputFile in outputFiles) {
                int fileNumber = outputFile.Key;

                using (System.IO.StreamWriter f = new System.IO.StreamWriter(@desktopDIR + "\\" + outputFileName + "_" + outputFile.Key + ".hbq"))
                {
                    f.WriteLine(Properties.Resources.HBQHeader);
                    foreach (string file in outputFile.Value)
                    {
                        string filename = Path.GetFileName(file).Replace("&", "&amp;");

                        string destinationFile = destinationDIR.Text + "\\" + filename;
                        if (retainParentFolder.Checked == true)
                        {
                            FileInfo fileInfo = new FileInfo(file);
                            string filenameParentDirectory = fileInfo.Directory.Name.Replace("&", "&amp;");
                            destinationFile = destinationDIR.Text + "\\" + filenameParentDirectory + "\\" + filename;
                        }

                        string individualQueueTask = blankQueueTask;
                        individualQueueTask = individualQueueTask.Replace("{$source}", file);
                        individualQueueTask = individualQueueTask.Replace("{$destination}", destinationFile);
                        individualQueueTask = individualQueueTask.Replace("{$width}", textBoxWidth.Text);
                        individualQueueTask = individualQueueTask.Replace("{$height}", textBoxHeight.Text);

                        f.WriteLine(individualQueueTask);
                        toolStripProgressBar.Increment(1);
                    }
                    f.WriteLine(Properties.Resources.HBQFooter);
                }

            }
            toolStripStatusLabel.Text = "Finished, Created " + numericNumberOfFiles.Value.ToString() + " files in " + desktopDIR;
        }

        private void comboAspectRatio_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboAspectRatio.Text)
            {
                case "16:9":
                    textBoxWidth.Text = "800";
                    textBoxHeight.Text = "450";
                    toolStripStatusLabel.Text = "Aspect ratio set to 16:9";
                    break;
                case "4:3":
                    textBoxWidth.Text = "640";
                    textBoxHeight.Text = "480";
                    toolStripStatusLabel.Text = "Aspect ratio set to 4:3";
                    break;
            }
            generateOutPutExample();
        }

        private void buttonFindSourceDIR_Click_1(object sender, EventArgs e)
        {
            folderSourceDIR.SelectedPath = sourceDIR.Text;
            if (folderSourceDIR.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                sourceDIR.Text = folderSourceDIR.SelectedPath;
                Properties.Settings.Default.source_directory = sourceDIR.Text;
                Properties.Settings.Default.Save();
                toolStripStatusLabel.Text = "Source directory set to: " + sourceDIR.Text;
                generateOutPutExample();
            }
        }

        private void buttonFindDestinationDIR_Click_1(object sender, EventArgs e)
        {
            folderDestinationDIR.SelectedPath = sourceDIR.Text;
            if (folderDestinationDIR.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                destinationDIR.Text = folderDestinationDIR.SelectedPath;
                Properties.Settings.Default.destination_directory = destinationDIR.Text;
                Properties.Settings.Default.Save();
                toolStripStatusLabel.Text = "Destination directory set to: " + destinationDIR.Text;
                generateOutPutExample();
            }
        }

        private void checkBoxOverrideWH_CheckedChanged(object sender, EventArgs e)
        {

            textBoxHeight.ReadOnly = !checkBoxOverrideWH.Checked;
            textBoxWidth.ReadOnly = !checkBoxOverrideWH.Checked;

        }

        private void comboFileTypes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string newFileType = comboFileTypes.Text.ToString();
                comboFileTypes.Items.Add(newFileType);
                MessageBox.Show("Added " + newFileType + " to file types list.", "Added File Extension");
                generateOutPutExample();
            }
        }

        private void addFileType_Click(object sender, EventArgs e)
        {
            string newFileType = comboFileTypes.Text.ToString();
            comboFileTypes.Items.Add(newFileType);
            MessageBox.Show("Added " + newFileType + " to file types list.", "Added File Extension");
            generateOutPutExample();
        }

        private void removeFileType_Click(object sender, EventArgs e)
        {
            comboFileTypes.Items.RemoveAt(comboFileTypes.SelectedIndex);
            comboFileTypes.SelectedIndex = 0;
            generateOutPutExample();
        }


        public void generateOutPutExample()
        {
            
            // https://stackoverflow.com/a/54213859/1445985
            var comboValues = comboFileTypes.Items.Cast<string>();
            var files = Directory.EnumerateFiles(sourceDIR.Text, "*.*", SearchOption.AllDirectories).Where(s => comboValues.Any(v => s.EndsWith(v, StringComparison.OrdinalIgnoreCase)));

            string desktopDIR = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            int numberOfFiles = (int)numericNumberOfFiles.Value;
            int fileCount = files.Count() - 1;
            int itemsInEachFile = (fileCount / numberOfFiles); // 98
            int remainder = (fileCount % numberOfFiles); // 1


            string file = files.ElementAt(0).Replace("&", "&amp;");
            string filename = Path.GetFileName(file);


            // Build example output to inform the user of whats going on.
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(fileCount.ToString() + " files found.");

            string destinationFile = destinationDIR.Text + "\\" + filename;
            if (retainParentFolder.Checked == true)
            {
                FileInfo fileInfo = new FileInfo(file);
                string filenameParentDirectory = fileInfo.Directory.Name.Replace("&", "&amp;");
                destinationFile = destinationDIR.Text + "\\" + filenameParentDirectory + "\\" + filename;
            }

            stringBuilder.AppendLine("Source File: " + file);
            stringBuilder.AppendLine("Destination File: " + destinationFile);

            // Output to textbox
            exampleOutput.Text = stringBuilder.ToString();

        }

        private void retainParentFolder_CheckedChanged(object sender, EventArgs e)
        {
            generateOutPutExample();
        }
    }
}