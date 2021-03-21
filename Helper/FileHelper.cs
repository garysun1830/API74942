using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace APIHome
{
    public static class FileHelper
    {

        private static string GetN(string Text)
        {
            if (string.IsNullOrWhiteSpace(Text))
                return null;
            Match m = Regex.Match(Text, "\\d+");
            if (!m.Success)
                return null;
            return m.Value;
        }

        public static string[] ListFile(string Folder, string Pattern)
        {
            List<string> files = new List<string>();
            Directory.GetFiles(Folder, Pattern).ToList().ForEach(fn =>
            {
                files.Add(GetN(Path.GetFileName(fn)));
            });
            return files.ToArray();
        }
    }
}