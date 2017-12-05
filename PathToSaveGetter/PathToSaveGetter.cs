using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathToSaveGetter
{
    public static class PathToSaveGetter
    {
        public static string GetPathFromFile_PathToParsedDataTXT()
        {
            return File.ReadAllText(Environment.CurrentDirectory + "/PathToParsedData.txt");
        }

        public static string GetPathFromFile_PathToParsedDataTXT(string path)
        {
            return File.ReadAllText(path + "/PathToParsedData.txt");
        }

        public static string GetPathFromFile(string path, string fileName)
        {
            return File.ReadAllText(path + "/PathToParsedData.txt");
        }

        public static string GetPathFromFile(string fullPath)
        {
            return File.ReadAllText(fullPath);
        }


    }
}
