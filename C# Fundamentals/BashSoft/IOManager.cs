using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public static class IOManager
{
    public static void TraverseDirectory(int depth)
    {
        OutputWriter.WriteEmptyLine();
        int initialIdentation = SessionData.currentPath.Split("\\").Length;
        Queue<string> subFolders = new Queue<string>();
        subFolders.Enqueue(SessionData.currentPath);

        while (subFolders.Count != 0)
        {
            string currentPath = subFolders.Dequeue();
            int identation = currentPath.Split("\\").Length - initialIdentation;
            OutputWriter.WriteMessageOnNewLine(string.Format("{0}{1}", new string('-', identation), currentPath));

            //foreach (var directoryPath in Directory.GetDirectories(currentPath))
            //{
            //    int index = directoryPath.LastIndexOf("\\");
            //    string fileName = directoryPath.Substring(index);
            //    OutputWriter.WriteMessageOnNewLine(directoryPath);
            //}
            foreach (var file in Directory.GetFiles(currentPath))
            {
                if (depth - identation < 0)
                {
                    break;
                }
                int indexOfLastSlash = file.LastIndexOf("\\");
                string fileName = file.Substring(indexOfLastSlash);
                OutputWriter.WriteMessageOnNewLine(new string('-', indexOfLastSlash) + fileName);
            }

            string[] subDirectories = Directory.GetDirectories(currentPath);
            foreach (var directory in subDirectories)
            {
                subFolders.Enqueue(directory);
            }
        } 
    }
    public static void CreateDirectoryInCurrentFolder(string name)
    {
        string path = Directory.GetCurrentDirectory() + "\\" + name;
        Directory.CreateDirectory(path);
    }
}