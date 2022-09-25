//Created by Alexander Fields https://github.com/roku674
using System.IO;

namespace Algorithms
{
    public static class FileManipulation
    {
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

        /// <summary>
        /// Delets the directory if it exists
        /// </summary>
        /// <param name="path"></param>
        public static void DeleteDirectory(string path, bool deleteContents)
        {
            if (Directory.Exists(path))
            {
                if (deleteContents)
                {
                    Directory.Delete(path, deleteContents);
                }
                else
                {
                    Directory.Delete(path);
                }
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
        /// Call this method to get a file form the itnernet
        /// </summary>
        /// <param name="hyperlink">Link to the file</param>
        /// <param name="filePath">File created from the link</param>
        public static void GetFileFromInternet(string hyperlink, string filePath)
        {
            System.Net.WebClient webClient = new System.Net.WebClient();
            Stream stream = webClient.OpenRead(hyperlink);
            StreamReader reader = new StreamReader(stream);
            File.WriteAllText(filePath, reader.ReadToEnd());
            
            reader.Close();
            stream.Close();
            webClient.Dispose();
        }
    }
}
