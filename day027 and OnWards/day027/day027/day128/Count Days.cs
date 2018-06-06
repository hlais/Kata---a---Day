using System;
using System.Linq;




namespace CodeWars6Kata
{
    class Count_Days
    {
        static public string countDays(DateTime d)
        {

            DateTime todaysDate = DateTime.Now;

            double days =  Math.Truncate((d - todaysDate).TotalDays);
            string strgDays = days.ToString();

            if (strgDays.Contains('-'))
            {
                return "The day is in the past!";
            }
            else if (strgDays == "0")
            {
                return "Today is the day!";
            }
            else 

            return $"{days.ToString()} days";

        }
    }
}
