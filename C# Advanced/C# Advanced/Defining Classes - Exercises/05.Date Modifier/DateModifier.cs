using System;

namespace DefiningClasses
{
    public class DateModifier
    { 
        public TimeSpan GetDifference(int[] firstDate, int[] secondDate)
        {
            int firstYear = firstDate[0];
            int firstMonth = firstDate[1];
            int firstDay = firstDate[2];
            
            int secondYear = secondDate[0];
            int secondMonth = secondDate[1];
            int secondDay = secondDate[2];

            DateTime firstDT = new DateTime(firstYear, firstMonth, firstDay);
            DateTime secondDT = new DateTime(secondYear, secondMonth, secondDay);

            return secondDT.Subtract(firstDT);
        }
    }
}