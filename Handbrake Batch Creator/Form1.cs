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
            var files = Directory.EnumerateFiles(sourceDIR.Text, "*.*", SearchOption.AllDirectories).Where(s => s.EndsWith(".mp4") || s.EndsWith(".mov"));
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
                for (int x = ((i-1) * itemsInEachFile + (i > 1 ? 1 : 0)); x <= (itemsInEachFile * i) + (i == numberOfFiles ? remainder : 0); x++)
                { 
                    tmpList.Add(files.ElementAt(x));
                }
                outputFiles.Add(i, tmpList);
            }
            
            foreach(KeyValuePair<int, List<string>> outputFile in outputFiles) {
                int fileNumber = outputFile.Key;

                using (System.IO.StreamWriter f = new System.IO.StreamWriter(@desktopDIR + "\\" + outputFileName + "_" + outputFile.Key + ".hbq"))
                {
                    f.WriteLine(Properties.Resources.HBQHeader);
                    foreach (string file in outputFile.Value)
                    {
                        string filename = Path.GetFileName(file);
                        string individualQueueTask = blankQueueTask;
                        individualQueueTask = individualQueueTask.Replace("{$source}", file);
                        individualQueueTask = individualQueueTask.Replace("{$destination}", destinationDIR.Text + "\\" + filename);
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
            switch(comboAspectRatio.Text)
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
            }
        }

        private void checkBoxOverrideWH_CheckedChanged(object sender, EventArgs e)
        {

            textBoxHeight.ReadOnly = !checkBoxOverrideWH.Checked;
            textBoxWidth.ReadOnly = !checkBoxOverrideWH.Checked;

        }

    }
}
