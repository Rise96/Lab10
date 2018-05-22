using System;

namespace Lab10
{
    class DaysInYear
    {
        public int NumberOfDaysInYear(string yearString)
        {
            int year = Convert.ToInt32(yearString);
            int days = 365;
            if ((year % 4) == 0)
            {
                if ((year % 400) == 0)
                {
                    days++;
                }
            }

            return days;
        }
    }
}