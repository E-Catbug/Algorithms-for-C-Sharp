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

        /// <summary>
        /// Creates the directory if the directory does not already exist
        /// </summary>
        /// <param name="path"></param>
        public static void CreateDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}