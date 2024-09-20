using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Function2
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a year: ");
        int userInput = Convert.ToInt32(Console.ReadLine());
        string result = CheckLeapYear(userInput);
        Console.WriteLine(result);
    }

    public static string CheckLeapYear(int inputYear)
    {
        if (inputYear % 4 == 0)
        {
            if (inputYear % 100 != 0 || inputYear % 400 == 0)
            {
                return "The year is a leap year.";
            }
        }
        return "The year is not a leap year.";
    }
}