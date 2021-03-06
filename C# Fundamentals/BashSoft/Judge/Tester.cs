using System;
using System.IO;

public static class Tester
{
    public static void CompareContent(string userOutputPath, string expectedOutputPath)
    {
        try
        {
            OutputWriter.WriteMessageOnNewLine("Reading files...");

            string mismatchPath = GetMismatchPath(expectedOutputPath);

            string[] actualOutputLines = File.ReadAllLines(userOutputPath);
            string[] expectedOutputLines = File.ReadAllLines(expectedOutputPath);

            bool hasMismatch;
            string[] mismatches = GetLinesWithPossibleMismatches(actualOutputLines, expectedOutputLines, out hasMismatch);
            PrintOutput(mismatches, hasMismatch, mismatchPath);
            OutputWriter.WriteMessageOnNewLine("Files read!");
        }
        catch (FileNotFoundException)
        {
            OutputWriter.DisplayException(ExceptionMessages.InvalidPath);
        }
    }
    private static string GetMismatchPath(string expectedOutputPath)
    {
        int indexOf = expectedOutputPath.LastIndexOf('\\');
        string directoryPath = expectedOutputPath.Substring(0, indexOf);
        string finalPath = directoryPath + @"\Mismatches.txt";
        return finalPath;
    }
    private static string[] GetLinesWithPossibleMismatches(string[] actualOutputLines, string[] expectedOutputLines, out bool hasMismatch)
    {
        hasMismatch = false;
        string output = string.Empty;
        string[] mismatches = new string[actualOutputLines.Length];
        OutputWriter.WriteMessageOnNewLine("Comparing files...");
        for (int i = 0; i < actualOutputLines.Length; i++)
        {
            string actualLine = actualOutputLines[i];
            string expectedLine = expectedOutputLines[i];
            if (!actualLine.Equals(expectedLine)) 
            {
                output = string.Format($"Mismatch at line {i} -- expected: \"{expectedLine}\", actual: \"{actualLine}\"");
                output += Environment.NewLine;
                hasMismatch = true;
            }
            else
            {
                output = actualLine;
                output += Environment.NewLine;
            }
            mismatches[i] = output;
        }
        return mismatches;
    }
    private static void PrintOutput(string[] mismatches, bool hasMismatch, string mismatchesPath)
    {
        if (hasMismatch)
        {
            foreach (var line in mismatches)
            {
                OutputWriter.WriteMessageOnNewLine(line);
            }
            try
            {
                File.WriteAllLines(mismatchesPath, mismatches);
            }
            catch (DirectoryNotFoundException)
            {
                OutputWriter.DisplayException(ExceptionMessages.InvalidPath);
            }
            return;
        }
        else
        {
            OutputWriter.WriteMessageOnNewLine("Files are identical. There are no mismatches.");
            return;
        }
    }
}