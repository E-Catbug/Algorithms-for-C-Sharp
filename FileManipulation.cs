//Created by Alexander Fields https://github.com/roku674
using System;
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
        /// Inserts a replacement line into a file
        /// </summary>
        /// <param name="fileAsArray">The file as a string array</param>
        /// <param name="newText">new line you want to insert</param>
        /// <param name="line_to_edit">which line you want to edit by number</param>
        /// <returns>the edited file as a string array </returns>
        public static string[] LineChanger(string[] fileAsArray, string newText, long line_to_edit)
        {
            if (fileAsArray.LongLength <= line_to_edit) //resize array if length is less than thje line you want to edit
            {
                Array.Resize(ref fileAsArray, (int)line_to_edit + 1);
            }

            fileAsArray[line_to_edit] = newText; //edit the line
            return fileAsArray; //return string
        }

        /// <summary>
        /// Deletes a directory
        /// </summary>
        /// <param name="path">path of directory</param>
        /// <param name="deleteContents">if true will delete the files and directories in directory</param>
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
        /// Deletes the directory if it exists
        /// </summary>
        /// <param name="path">path of directory</param>
        /// <param name="deleteContents">if true will delete the files and directories in directory</param>
        /// <returns>An exception if any or returns null if no exception found</returns>
        public static Exception DeleteDirectoryTry(string path, bool deleteContents)
        {
            try
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
            catch (Exception e)
            {
                return e;
            }
            return null;
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

        public static Exception DeleteFileTry(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
            }
            catch (Exception e)
            {
                return e;
            }
            return null;
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