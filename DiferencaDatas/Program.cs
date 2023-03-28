using System;
class URI
{
    static void Main(string[] args)
    {
        string[] input1 = Console.ReadLine().Split();
        int day1 = int.Parse(input1[0]);
        int month1 = int.Parse(input1[1]);
        string[] input2 = Console.ReadLine().Split();
        int day2 = int.Parse(input2[0]);
        int month2 = int.Parse(input2[1]);
        int daysInMonth1 = GetDaysInMonth(month1);
        int daysInMonth2 = GetDaysInMonth(month2);
        int days = day2 - day1;
        for (int i = month1; i < month2; i++)
        {
            days += GetDaysInMonth(i);
        }
        Console.WriteLine("{0}", days);
    }
    static int GetDaysInMonth(int month)
    {
        if (month == 2)
        {
            return 28;
        }
        else if (month == 4 || month == 6 || month == 9 || month == 11)
        {
            return 30;
        }
        else
        {
            return 31;
        }
    }
}