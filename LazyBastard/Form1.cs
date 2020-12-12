using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LazyBastard
{
    public partial class lazyBastard : Form
    {
        private FolderBrowserDialog folderBrowser;
        private List<string> directoryList;
        private List<string> filespath;
        private IDictionary<String, int> extensions;


        private String filenameTarget;
        private String filenameDestination;

        public lazyBastard()
        {
            InitializeComponent();
            this.folderBrowser = new FolderBrowserDialog();

            directoryList = new List<string>();
            filespath = new List<string>();
            extensions = new Dictionary<String, int>();
        }


        private void targetFolderButton_Click(object sender, EventArgs e)
        {
            folderBrowser.ShowDialog();
            filenameTarget = folderBrowser.SelectedPath;
            logBox.Text += "\n Target Directory Selected :" + filenameTarget;
            destinationButton.Enabled = true;
            MapFiles(filenameTarget);
            FillChart();
            fillChecklist();
            numberFilesMaped.Text = "Files Maped :" + filespath.Count.ToString();
        }



        private void startButton_Click(object sender, EventArgs e)
        {

        }

        private void destinationButton_Click(object sender, EventArgs e)
        {
            folderBrowser.ShowDialog();
            filenameDestination = folderBrowser.SelectedPath;
            logBox.Text += "\n Destination Directory Selected :" + filenameTarget;
            startButton.Enabled = true;
        }


        public void fillChecklist()
        {
            //extensionCheckListBox.Items.AddRange(extensions.Keys.ToList());
            extensionCheckListBox.Enabled = true;
            foreach (KeyValuePair<string, int> v in extensions.OrderByDescending(x=>x.Value))
            {
                extensionCheckListBox.Items.Add($"{v.Key} ({v.Value})");
            }
        }

        private void MapFiles(string directorypath)
        {
            // logBox.Text += "\n starting maping";
            try
            {
                string[] folder = Directory.GetDirectories(directorypath);
                string[] files = Directory.GetFiles(directorypath);


                if (folder.Length > 0)
                {
                    foreach (string v in folder)
                    {
                        directoryList.Add(v);
                        MapFiles(v);
                    }
                }
                if (files.Length > 0)
                {
                    foreach (string v in files)
                    {
                        filespath.Add(v);
                        string extension = Path.GetExtension(v);
                        bool ex = extensions.ContainsKey(extension);

                        if (ex)
                        {
                            extensions[extension] += 1;
                        }
                        else
                        {
                            extensions.Add(extension, 1);

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                logBox.Text += "\n " + ex.Message;
            }
        }

        private void FillChart()
        {
            logBox.Text += "\n starting chart";
            fileChart.Titles.Add("Extensions");

            fileChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Funnel;
            fileChart.Legends[0].Enabled = true;

            foreach (KeyValuePair<string, int> v in extensions)
            {

                fileChart.Series[0].Points.AddXY(v.Key, v.Value);
            }
        }

    }
}
