using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Domain = LC.Domain;

namespace LC.Services
{
    public static class FileManager
    {
        public static bool CheckFileExist(string file)
        {
            return new FileInfo(file).Exists;
        }

        public static FileInfo GetFile(string file)
        {
            return new FileInfo(file);
        }

        public static List<FileInfo> GetFiles(List<string> files)
        {
            List<FileInfo> result = new List<FileInfo>();

            foreach (var file in files)
            {
                if (!CheckFileExist(file))
                    continue;

                result.Add(GetFile(file));
            }

            return result;
        }

        public static List<FileInfo> GetFiles(string folderDirectory)
        {
            return new DirectoryInfo(folderDirectory).GetFiles().ToList();
        }

        public static string GetRootFileDirectory(string file)
        {
            var split = file.Split('\\');

            string result = string.Empty;

            for (int i = 0; i < split.Count() - 1; i++)
            {
                if (result == string.Empty)
                    result = split[i];
                else
                    result = result + "\\" + split[i];
            }

            return result;
        }

        public static void Copy(string sourceFile, string destinyFolder, string filename, bool overWrite)
        {
            var fileInfo = new FileInfo(sourceFile);
            fileInfo.CopyTo($"{destinyFolder}\\{filename}", overWrite);
        }

        public static void DeleteFolder(string folder)
        {
            var dInfo = new DirectoryInfo(folder);
            dInfo.Delete(true);
        }

        public static bool FolderExists(string folder)
        {
            var dInfo = new DirectoryInfo(folder);
            return dInfo.Exists;
        }

        public static void CreateDirectory(string folder)
        {
            var dInfo = new DirectoryInfo(folder);
            dInfo.Create();
        }

        public static string GetLocalPath()
        {
            var basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            basePath = basePath.Replace("file:\\", string.Empty);
            return basePath + "\\";
        }

        public static void OpenLocation(string folder)
        {
            Process.Start("explorer.exe", folder);
        }
    }
}
