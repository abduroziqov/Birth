namespace tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine(" Axrorbek ");

            DateTime dateTime1 = DateTime.Now;
            

            int day , month , year ;

            /// yil 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" \n Enter your birth year : ");
            year = Convert.ToInt32(Console.ReadLine());

            /// oy 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" \n Enter your birth month : ");
            month = Convert.ToInt32(Console.ReadLine());

            // kun 
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\n Enter your birth day : ");
            day = Convert.ToInt32(Console.ReadLine());

            DateTime dateTime2 = new DateTime(year , month , day);
            Console.ForegroundColor = ConsoleColor.Yellow;

            TimeSpan dateTime = dateTime1 - dateTime2;
           
            Console.WriteLine($" \n You were born {dateTime.Days / 365} year , {dateTime.Days % 365 / 30} month and {dateTime.Days % 365 % 30} days ago ");
            Console.WriteLine("\n you were born on "+dateTime2.DayOfWeek);

            Console.ForegroundColor = ConsoleColor.White;
            DateTime PresentTime3 = DateTime.Now;
            DateTime futureTime =  dateTime2.AddYears((dateTime.Days / 365)+1);

            TimeSpan nextTime = futureTime - PresentTime3;

            Console.ForegroundColor= ConsoleColor.DarkYellow;
            Console.WriteLine($"\n your next birthday is {futureTime.DayOfWeek}");
            Console.WriteLine($" \n {nextTime.Days % 365 / 30} month and {nextTime.Days % 365 % 30} days until your next birhtday");
            Console.ForegroundColor = ConsoleColor.White;


        }
    }
}