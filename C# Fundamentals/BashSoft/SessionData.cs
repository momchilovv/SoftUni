using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public static class SessionData
{
    public static string currentPath = Directory.GetCurrentDirectory();

    public static void CreateDirectoryInCurrentFolder(string name)
    {
        string path = Directory.GetCurrentDirectory() + "\\" + name;
        Directory.CreateDirectory(path);
    }
}