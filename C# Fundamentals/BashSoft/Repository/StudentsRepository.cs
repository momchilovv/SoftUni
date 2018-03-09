using System;
using System.Linq;
using System.Text.RegularExpressions;
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
            string pattern = @"([A-Z][a-zA-Z#+]*_[A-Z][a-z]{2}_\d{4})\s+([A-Z][a-z]{0,3}\d{2}_\d{2,4})\s+(\d+)";
            Regex regex = new Regex(pattern);

            string[] inputAllLines = File.ReadAllLines(path);
            for (int i = 0; i < inputAllLines.Length; i++)
            {
                if (!string.IsNullOrEmpty(inputAllLines[i]) && regex.IsMatch(inputAllLines[i]))
                {
                    Match currentMatch = regex.Match(inputAllLines[i]);
                    string courseName = currentMatch.Groups[1].Value;
                    string username = currentMatch.Groups[2].Value;
                    int studentScoreOnTask;
                    bool hasParsedScore = int.TryParse(currentMatch.Groups[3].Value, out studentScoreOnTask);

                    if (hasParsedScore && studentScoreOnTask >= 0 && studentScoreOnTask <= 100)
                    {
                        if (!studentsByCourse.ContainsKey(courseName))
                        {
                            studentsByCourse.Add(courseName, new Dictionary<string, List<int>>());
                        }
                        if (!studentsByCourse[courseName].ContainsKey(username)) 
                        {
                            studentsByCourse[courseName].Add(username, new List<int>());
                        }
                        studentsByCourse[courseName][username].Add(studentScoreOnTask);
                    }
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
    public static void FilterAndTake(string courseName, string givenFilter, int? studentsToTake = null)
    {
        if (IsQueryForCoursePossible(courseName))
        {
            if (studentsToTake == null)
            {
                studentsToTake = studentsByCourse[courseName].Count;
            }
            RepositoryFilters.FilterAndTake(studentsByCourse[courseName], givenFilter, studentsToTake.Value);
        }
    }
    public static void OrderAndTake(string courseName, string comparison, int? studentsToTake = null)
    {
        if (IsQueryForCoursePossible(courseName))
        {
            if (studentsToTake == null)
            {
                studentsToTake = studentsByCourse[courseName].Count;
            }
            RepositorySorters.OrderAndTake(studentsByCourse[courseName], comparison, studentsToTake.Value);
        }
    }
}