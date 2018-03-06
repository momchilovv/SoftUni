using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

public static class StudentsRepository
{
    public static bool isDataInitialized = false;
    public static Dictionary<string, Dictionary<string, List<int>>> studentsByCourse;

    public static void InitializeData(string fileName)
    {
        if (!isDataInitialized)
        {
            OutputWriter.WriteMessageOnNewLine("Reading data...");
            studentsByCourse = new Dictionary<string, Dictionary<string, List<int>>>();
            ReadData(fileName);
        }
        else
        {
            OutputWriter.WriteMessageOnNewLine(ExceptionMessages.DataInitializedException);
        }
    }

    private static void ReadData(string fileName)
    {
        string path = SessionData.currentPath + "\\" + fileName;
        if (File.Exists(path))
        {
            string[] inputAllLines = File.ReadAllLines(path);
            for (int i = 0; i < inputAllLines.Length; i++)
            {
                if (!string.IsNullOrEmpty(inputAllLines[i]))
                {
                    string[] data = inputAllLines[i].Split();
                }
            }
        }

        isDataInitialized = true;
        OutputWriter.WriteMessageOnNewLine("Data read!");
    }
    private static bool IsQueryForCoursePossible(string courseName)
    {
        if (isDataInitialized)
        {
            if (studentsByCourse.ContainsKey(courseName))
            {
                return true;
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InexistingCourseInDataBase);
            }
        }
        else
        {
            OutputWriter.DisplayException(ExceptionMessages.DataNotInitializedException);
        }
        return false;
    }
    private static bool IsQueryForStudentsPossible(string courseName, string studentUserName)
    {
        if (IsQueryForCoursePossible(courseName) && studentsByCourse[courseName].ContainsKey(studentUserName))
        {
            return true;
        }
        else
        {
            OutputWriter.DisplayException(ExceptionMessages.InexistingStudentInDataBase);
        }
        return false;
    }
    public static void GetStudentScoresFromCourse(string courseName, string username)
    {
        if (IsQueryForStudentsPossible(courseName, username))
        {
            OutputWriter.PrintStudent(new KeyValuePair<string, List<int>>(username, studentsByCourse[courseName][username]));
        }
    }
    public static void GetAllStudentsFromCourse(string courseName)
    {
        if (IsQueryForCoursePossible(courseName))
        {
            OutputWriter.WriteMessageOnNewLine($"{courseName}");
            foreach (var studentMarksEntry in studentsByCourse[courseName])
            {
                OutputWriter.PrintStudent(studentMarksEntry);
            }
        }
    }
}