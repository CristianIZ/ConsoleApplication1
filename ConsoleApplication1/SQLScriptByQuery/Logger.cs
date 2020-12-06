using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLScriptByQuery
{
    public static class Logger
    {
        private static string basePath = "./Logs";
        private static string logInfoPath = $"{basePath}/LogInfo.txt";
        private static string logErrorPath = $"{basePath}/LogError.txt";
        private static bool alreadyCheckedFolder = false;

        public static void LogInfo(string text)
        {
            WriteFile(text, logInfoPath);
        }

        public static void LogError(string text)
        {
            WriteFile(text, logErrorPath);
        }

        public static StringBuilder GetLogInfo()
        {
            return ReadFile(logInfoPath);
        }

        public static StringBuilder GetLogError()
        {
            return ReadFile(logErrorPath);
        }

        private static void WriteFile(string text, string logPath)
        {
            CheckFolder(basePath);
            using (var sr = new StreamWriter(logPath, true))
            {
                sr.WriteLine($"{DateTime.Now} -- {text}");
            }
        }

        private static StringBuilder ReadFile(string filePath)
        {
            var builder = new StringBuilder();

            using (var sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                    builder.AppendLine(sr.ReadLine());
            }

            return builder;
        }

        private static void CheckFolder(string path)
        {
            if (!alreadyCheckedFolder)
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                alreadyCheckedFolder = true;
            }
        }
    }
}
