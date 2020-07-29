using System;

namespace Lab4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string[] tasks = new string[7];

            for(int i = 0; i < days.Length; i++)
            {
                Console.WriteLine("Enter a task for " + days[i]);
                tasks[i] = days[i] + ":  " + Console.ReadLine();
            }

            foreach(string t in tasks)
            {
                Console.WriteLine(t);
            }
        }
    }
}
