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

            try
            {
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
            catch (UnauthorizedAccessException)
            {
                OutputWriter.DisplayException(ExceptionMessages.UnauthorizedAccess);
            }
        }
    }
    public static void CreateDirectoryInCurrentFolder(string name)
    {
        string path = Directory.GetCurrentDirectory() + "\\" + name;
        try
        {
            Directory.CreateDirectory(path);
        }
        catch (ArgumentException)
        {
            OutputWriter.DisplayException(ExceptionMessages.ForbiddenSymbolContained);
        }
    }
    public static void ChangeCurrentDirectoryRelative(string relativePath)
    {
        if (relativePath == "..")
        {
            try
            {
                string currentPath = SessionData.currentPath;
                int indexOfSlash = currentPath.LastIndexOf("\\");
                string newPath = currentPath.Substring(0, indexOfSlash);
                SessionData.currentPath = newPath;
            }
            catch (ArgumentOutOfRangeException)
            {
                OutputWriter.DisplayException(ExceptionMessages.UnableToGoHigherInPartitionHierarchy);
            }
        }
        else
        {
            string currentPath = SessionData.currentPath;
            currentPath += "\\" + relativePath;
            ChangeCurrentDirectoryRelative(currentPath);
        }
    }
    public static void ChangeCurrentDirectoryAbsolute(string absolutePath)
    {
        if (!Directory.Exists(absolutePath))
        {
            OutputWriter.DisplayException(ExceptionMessages.InvalidPath);
            return;
        }

        SessionData.currentPath = absolutePath;
    }
}