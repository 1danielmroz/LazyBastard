using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LazyBastard
{
    public partial class lazyBastard : Form
    {
        private FolderBrowserDialog folderBrowser;
        
        private String filenameTarget;
        private String filenameDestination;

        public lazyBastard()
        {
            InitializeComponent();
            this.folderBrowser = new FolderBrowserDialog();
        }

      
        private void targetFolderButton_Click(object sender, EventArgs e)
        {
            folderBrowser.ShowDialog();
            filenameTarget = folderBrowser.SelectedPath;
            logBox.Text += "\n Target Directory Selected :" + filenameTarget;
            destinationButton.Enabled = true;
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
    }
}
