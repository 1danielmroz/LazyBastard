using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_BASTARD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private FolderBrowserDialog folderBrowser;

        MainProgram MainProgram;


        public MainWindow()
        {
            InitializeComponent();
            MainProgram = new MainProgram();
            this.folderBrowser = new FolderBrowserDialog();
        }

        private async void analyzeFolder_ClickAsync(object sender, RoutedEventArgs e)
        {
            folderBrowser.ShowDialog();
            string filenameTarget = folderBrowser.SelectedPath;
            await MainProgram.ScanAsync(filenameTarget);

            textToDisplay.Text = MainProgram.textDisplay;


        }
    }
}
