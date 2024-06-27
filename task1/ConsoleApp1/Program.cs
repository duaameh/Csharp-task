namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.	Write a C# program that accept two integers and display the smaller. 
            Console.WriteLine("Enter  two integers number");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if (x > y) { Console.WriteLine($"the {y} is smaller"); }
            else { Console.WriteLine($"the {x} is smaller"); }

            //Write a C# conditional statement to find the sign  of input  number
            Console.WriteLine("enter number ");
            int x2 = int.Parse(Console.ReadLine());
            if (x2 < 0)
            {
                Console.WriteLine("The sign is -");
            }
            else
            {
                Console.WriteLine("The sign is +");

            }
            //sort three numbers ascending
            Console.WriteLine("Enter three numbers:");

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int temp;

            if (num1 > num2)
            {
                temp = num1;
                num1 = num2;
                num2 = temp;
            }



            if (num2 > num3)
            {
                temp = num2;
                num2 = num3;
                num3 = temp;
            }
            Console.WriteLine($"Sorted numbers: {num1}, {num2}, {num3}");
            //find the max of five numbers
            int a = 3;
            int b = 2;
            int c = 3;
            int d = 4;
            int e = 50;
            if (a > b & a > c & a > d & a > e) { Console.WriteLine(a); }
            else if (b > a & b > c & b > d & b > e) { Console.WriteLine(b); }
            else if (c > a & c > b & c > d & c > e) { Console.WriteLine(c); }
            else if (d > a & d > c & d > b & d > e) { Console.WriteLine(d); }
            else { Console.WriteLine(e); }
            // km
            Console.Write("Enter speed in kilometers per hour (km/h):");
            double speedKmH = double.Parse(Console.ReadLine());

            double speedMph = speedKmH * 0.621371; ;

            Console.WriteLine($"Speed in miles per hour (mph): {speedMph:F3}");
            //houres
            Console.Write("Enter hours:");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Enter minutes:");
            int minutes = int.Parse(Console.ReadLine());
            Console.WriteLine($"total is {hours * 60 + minutes}");
            //minutes
            Console.Write("Enter minutes :");
            int minutes2 = int.Parse(Console.ReadLine());
            int hours2 = 0; int min = minutes;
            if (minutes / 60 != 0)
            {
                hours = minutes / 60;
                min = minutes % 60;
            }
            Console.WriteLine($"The total is{hours} hours , {min}minutes ");
            //padding
            string[] sentences = { "Hello",
                "randooooooom",
                "Short randooom", "hiiiiiiiii alllllllllllll", "hola" };

            foreach (var sentence in sentences)
            {
                Console.WriteLine(sentence.Substring(0, Math.Min(sentence.Length, 9)));
            }

            Console.WriteLine(ReverseOdd("Bananas"));
            Console.WriteLine(ReverseOdd("One two three four"));
        }
        public static string ReverseOdd(string str)
        {
            return string.Join
                (" ", str.Split(' ').Select(word => word.Length % 2 == 0 ? word : new string(word.Reverse().ToArray())));
        }
    }
}
