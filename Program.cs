using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace AddDays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO: Create Methods
            Console.Write("Enter a number between 1 to 7: ");
            int dayNumber = Convert.ToInt16(Console.ReadLine());
            string day = Input(dayNumber);

            Console.Write("Input number to add to the day: ");
            int dayToAdd = Convert.ToInt16(Console.ReadLine());
            string addDays = (Plus(dayNumber,dayToAdd));
        }
        static string Input(int dayNumber)
        {
            string message = "";

            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("The day is MONDAY");
                    break;
                case 2:
                    Console.WriteLine("The day is TUESDAY");
                    break;
                case 3:
                    Console.WriteLine("The day is WEDNESDAY");
                    break;
                case 4:
                    Console.WriteLine("The day is THURSDAY");
                    break;
                case 5:
                    Console.WriteLine("The day is FRIDAY");
                    break;
                case 6:
                    Console.WriteLine("The day is SATURDAY");
                    break;
                case 7:
                    Console.WriteLine("The day is SUNDAY");
                    break;
                default:
                    Console.WriteLine("Invalid Input.");
                    break;
            }
            return message;
        }
            static string Plus(int dayNumber, int daytoAdd)
        {
            //Calculate the final day using method
            int finalDay = (dayNumber + daytoAdd + 7) % 7;
            Console.WriteLine("The final day is " + finalDay);

            string message = "";

            switch (finalDay)
            {
                case 1:
                    Console.WriteLine("The day is MONDAY");
                    break;
                case 2:
                    Console.WriteLine("The day is TUESDAY");
                    break;
                case 3:
                    Console.WriteLine("The day is WEDNESDAY");
                    break;
                case 4:
                    Console.WriteLine("The day is THURSDAY");
                    break;
                case 5:
                    Console.WriteLine("The day is FRIDAY");
                    break;
                case 6:
                    Console.WriteLine("The day is SATURDAY");
                    break;
                case 7:
                    Console.WriteLine("The day is SUNDAY");
                    break;
                default:
                    Console.WriteLine("Invalid Input.");
                    break;
            }
            return message;
        }
    }
}