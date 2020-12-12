using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_BASTARD
{
    public class MainProgram
    {
        public string textDisplay = "";
        public static List<FileInfo> files = new List<FileInfo>();

        public async Task ScanAsync(string path)
        {
             FindDirectorysRecursive(path);

            foreach (var x in files)
            {
                textDisplay += $"\n{x.FullName}";
            }
        }


        public static void FindDirectorysRecursive(string path)
        {
            try
            {
                DirectoryInfo d = new DirectoryInfo(path);//Assuming Test is your Folder
                DirectoryInfo[] directoryInfos = d.GetDirectories();
                files.AddRange(d.GetFiles().ToList()); //Getting Text files

                foreach (DirectoryInfo dir in directoryInfos)
                {
                    FindDirectorysRecursive(dir.FullName);
                }
            }catch(Exception ex)
            {
                string s = ex.Message;
            }
        }


    }
}
