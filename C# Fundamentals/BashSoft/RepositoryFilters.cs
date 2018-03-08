using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class RepositoryFilters
{
    public static void FilterAndTake(Dictionary<string, List<int>> wantedData, string wantedFilter, int studentsToTake)
    {
        if (wantedFilter == "excellent")
        {
            FilterAndTake(wantedData, x => x >= 5, studentsToTake);
        }
        else if (wantedFilter == "average")
        {
            FilterAndTake(wantedData, x => x < 5 && x >= 3.5, studentsToTake);
        }
        else if (wantedFilter == "poor")
        {
            FilterAndTake(wantedData, x => x < 3.5, studentsToTake);
        }
        else
        {
            OutputWriter.DisplayException(ExceptionMessages.InvalidStudentsFilter);
        }
    }
    private static void FilterAndTake(Dictionary<string, List<int>> wantedData, Predicate<double> givenFilter, int studentsToTake)
    {
        int counterForPrinted = 0;
        foreach (var usernamePoints in wantedData)
        {
            if (counterForPrinted == studentsToTake)
            {
                break;
            }
            double averageMark = usernamePoints.Value.Average();
            double percentage = averageMark / 100;
            double mark = percentage * 4 + 2;
            if (givenFilter(mark))
            {
                OutputWriter.PrintStudent(usernamePoints);
                counterForPrinted++;
            }
        }
    }
}