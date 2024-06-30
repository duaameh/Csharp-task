using System.Threading;

namespace task2
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {

            //int[] ARR = { 1, 7, 9, 45 };
            //string[] arr2 = { "Str", "alex", "moh" };
            //string[] arr3 = { "the", "fox", "over", "lazy", "dog" };
            ///*
            // 2-	What the index of "Banana","Tomato"?
            //"Banana"// index 1
            //"Tomato" //index 2
            //    String [ ]  fruits=["Tomato","Banana","Watermelon"]
            // */
            ////•	Favorite Food (5 item)
            //string[] favFood = { "pizza", "mansaf", "macrona","random ","random" };
            ////•	Favorite Sport 
            //string[] sport = { "RUN", "yoga" ,"random"};
            ////•	Favorite Movie (4 item)
            //string[] arr4 = { "me befor you", "love rose", "little women" };

            //the sum of three numbers with getting input in one line 
            ////Console.Write("Input three numbers separated by comma: ");
            ////string input = Console.ReadLine();
            ////string[] numbers = input.Split(',');
            ////int num1 = int.Parse(numbers[0]);
            ////int num2 = int.Parse(numbers[1]);
            ////int num3 = int.Parse(numbers[2]);
            ////int sum = num1 + num2 + num3;
            ////Console.WriteLine("The sum of three numbers: " + sum);

            //to display the n terms of odd number and their sum from [1- 100 ]. 
            ////int sum = 0;
            ////for (int i = 0; i < 100; i++)
            ////{
            ////    if (i % 2 == 1)
            ////    {
            ////        Console.Write($" {i}  ");
            ////        sum=sum+i;
            ////    }    
            ////}
            ////Console.WriteLine($" the sum is {sum}");
            //6-	Write a program in C## to display the pattern like right angle triangle using an asterisk. Go to the editor

            ////int n = 3; // Number of rows

            ////for (int i = 1; i <= n; i++)
            ////{
            ////    for (int j = 1; j <= i; j++)
            ////    {
            ////        Console.Write("*");
            ////    }
            ////    Console.WriteLine();
            ////}
            ////int rows = 4; 
            ////int num = 1; 

            ////for (int i = 1; i <= rows; i++)
            ////{
            ////    for (int j = 1; j <= rows - i; j++)
            ////    {
            ////        Console.Write("  ");
            ////    }

            ////    // print numbers
            ////    for (int k = 1; k <= i; k++)
            ////    {
            ////        Console.Write(num + " ");
            ////        num++;
            ////    }

            ////    Console.WriteLine(); // move to the next line
            ////}
            ////////////////////////////////////////task2///////////////////////////////////////////
            ///
            //1-	 Write a function in C# that accept 10 numbers and return sum and average.
            //////int sum = 0;
            //////Console.WriteLine("Enter 10 number");
            //////for (int i = 0; i <10; i++) 
            //////{
            //////    int x=int.Parse(Console.ReadLine());
            //////    sum = sum + x;
            //////}
            //////Console.WriteLine(sum);

            //2-	Write a program in C to display the cube of the number up to given an integer.
            ////Console.Write("Enter the number of terms: ");
            ////int n = Convert.ToInt32(Console.ReadLine());

            ////for (int i = 1; i <= n; i++)
            ////{
            ////    Console.WriteLine($"Number is : {i} and cube of the {i} is :{i * i * i}");
            ////}
            //Write a program in C# return only numbers in the years array greater than 1950.
            //int[] year = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            //getYears(year);
            //4-	Create a function that takes the age in years and returns the age in days.
            Console.WriteLine(ageDays(30));
            Console.WriteLine( Animals(2, 3, 5)); // returns 36
            string username = "user1";
            string password = "pass1";

            string result = Login(username, password);
            Console.WriteLine(result);
           Console.WriteLine( Power(2, 3));
            bool isleap = IsLeapYear(2004);
            Console.WriteLine($"the year is {isleap}");
            int number = 29;
            bool isPrime = IsPrime(number);
            Console.WriteLine($"{number} is a prime number: {isPrime}");

            /////////////////////task3//////////////////////////
            MyClass myClass = new MyClass();
            Message message = new Message();
            message.DisplayMessage("Scott");
            FactorialCalculator calculator = new FactorialCalculator();
            int number5 = 5; 
            long result5 = calculator.CalculateFactorial(number);
            Console.WriteLine($"The factorial of {number5} is {result5}.");

            int[] array = { 11, -2, 4, 35, 0, 8, -9 };
            ArraySorter sorter = new ArraySorter();
            int[] sortedArray = sorter.SortArray(array);
            Console.WriteLine("Sorted array: [{0}]", string.Join(", ", sortedArray));

        }

         static void printstring()
        {
            Console.WriteLine("MyClass class has initialized!");
        }
        static void printstring(string name)
        {
            Console.WriteLine($"Hello all i'm {name}");
        }
        static void getYears(int[] years)
        {
            for (int i = 0; i < years.Length; i++)
            {
                if (years[i] < 2020)
                    Console.WriteLine(years[i]);
            }
        }
        static int ageDays(int age) 
        {
            return age * 365;
        }
         static int Animals(int chickens, int cows, int pigs)
        {
            int totalLegs = chickens * 2 + cows * 4 + pigs * 4;
            return totalLegs;
        }
        public static string Login(string username, string password)
        {
            string[] predefinedUsers = new string[] { "user1:pass1", "user2:pass2", "admin:admin" };

            foreach (string user in predefinedUsers)
            {
                string[] credentials = user.Split(':');
                if (credentials[0] == username && credentials[1] == password)
                {
                    return "pass";
                }
            }

            return "failed";
        }
        static string Logins(string username, string password)
        {
         
            var users = new (string, string)[]
            {
            ("user1", "pass1"),
            ("user2", "pass2"),
            ("user3", "pass3")
            };

            foreach (var user in users)
            {
                if (user.Item1 == username && user.Item2 == password)
                {
                    return "Pass";
                }
            }

            return "Failed";
        }
        static double Power(double baseNumber, int exponent)
        {
            double result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result *= baseNumber;
            }

            return result;
        }
        static bool IsLeapYear(int year)
        {
            if (year < 1900 || year > 2024)
            {
                Console.WriteLine("some thing errore");
            }

            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
      
    }
    public class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("MyClass class has initialized!");
        }
    }
    public class Message
    {
        public void DisplayMessage(string name)
        {
            Console.WriteLine($"Hello All, I am {name}.");
        }
    }
    public class FactorialCalculator
    {
        public long CalculateFactorial(int number)
        {
           if (number == 0 || number == 1)
            {
                return 1;
            }
            else
            {
                long factorial = 1;
                for (int i = 2; i <= number; i++)
                {
                    factorial *= i;
                }
                return factorial;
            }
        }
    }
    public class ArraySorter
    {
        public int[] SortArray(int[] array)
        {
            Array.Sort(array);
            return array;
        }
    }

}

