using System;
using System.Security.Cryptography.X509Certificates;

namespace DateTime_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a date (dd_MM_yyyy): ");
            string dateTime = Console.ReadLine();

            try
            {
                DateTime date = DateTime.ParseExact(dateTime, "dd_MM_yyyy", null);
                Console.WriteLine("Tarix: " + date.ToString("dd/MM/yyyy"));
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Wrong date " + ex.Message);
            }
        }
    }
}
