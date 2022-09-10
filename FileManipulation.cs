//Created by Alexander Fields https://github.com/roku674
using System.IO;

namespace Algorithms
{
    public static class FileManipulation
    {
        /// <summary>
        /// Delets the directory if it exists
        /// </summary>
        /// <param name="path"></param>
        public static void DeleteDirectory(string path)
        {
            if (Directory.Exists(path))
            {
                Directory.Delete(path);
            }
        }

        /// <summary>
        /// Deletes the file if it exists
        /// </summary>
        /// <param name="path"></param>
        public static void DeleteFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}