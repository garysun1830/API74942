using System.Collections.Generic;
using System.IO;
using Unity;

namespace APIHome
{

    public static class Utility
    {
        public static string[] GetLocatonImages(string ImageFolder, string ImageSubFolder, string Location, string Filter)
        {
            string dir = Path.Combine(ImageFolder, ImageSubFolder, Location);
            return FileHelper.ListFile(dir, Filter);
        }
    }

}