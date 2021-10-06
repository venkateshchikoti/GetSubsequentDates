using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//class Program
//{
//    static void Main(string[] args)
//    {
//        // The code provided will print ‘Hello World’ to the console.
//        // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
//        Console.WriteLine("Hello World!");
//        Console.ReadKey();

//        // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
//    }
//}
namespace DatesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var from = DateTime.Today; // 25/8/2019
            var to = DateTime.Today.AddDays(230); // 23/9/2019
            var allMondays = from.GetWeekdayInRange(to, DayOfWeek.Monday);
            Console.ReadLine();
        }
    }
}

//Here is a solution with Extension.Gets a DateTime range and a day of week.
//Returns a list of DateTime.

public static class DateUtils
{
    public static List<DateTime> GetWeekdayInRange(this DateTime from, DateTime to, DayOfWeek day)
    {
        const int daysInWeek = 7;
        var result = new List<DateTime>();
        var daysToAdd = ((int)day - (int)from.DayOfWeek + daysInWeek) % daysInWeek;

        do
        {
            from = from.AddDays(daysToAdd);
            result.Add(from);
            daysToAdd = daysInWeek;
        } while (from < to);

        return result;
    }
}

