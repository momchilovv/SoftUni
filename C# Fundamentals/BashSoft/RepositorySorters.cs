using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class RepositorySorters
{
    public static void OrderAndTake(Dictionary<string, List<int>> wantedData, string comparison, int studentsToTake)
    {
        comparison = comparison.ToLower();
        if (comparison == "ascending")
        {
            PrintStudents(wantedData.OrderBy(x => x.Value.Sum()).Take(studentsToTake).ToDictionary(p => p.Key, p => p.Value));
        }
        else if (comparison == "descending")
        {
            PrintStudents(wantedData.OrderByDescending(x => x.Value.Sum()).Take(studentsToTake).ToDictionary(p => p.Key, p => p.Value));
        }
        else
        {
            OutputWriter.DisplayException(ExceptionMessages.InvalidComparisonQuery);
        }
    }
    private static void PrintStudents(Dictionary<string, List<int>> ordered)
    {
        foreach (KeyValuePair<string, List<int>> kvp in ordered)
        {
            OutputWriter.PrintStudent(kvp);
        }
    }
}