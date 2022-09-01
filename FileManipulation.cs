//Created by Alexander Fields https://github.com/roku674
namespace Algorithms
{
    public static class FileManipulation
    {
        public static void FileDeleteIfExists(string fileLocation)
        {
            if (System.IO.File.Exists(fileLocation))
            {
                System.IO.File.Delete(fileLocation);
            }
        }
    }
}