using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPcSharptask
{
    public class task3
    {
        public void WriteToFile(string fileName)
        {
            try
            {
                StreamWriter writer = new StreamWriter(fileName);
                writer.WriteLine("Name : duaa mehdawi");
                writer.WriteLine("Specialization : Software Engineering");
                writer.WriteLine("Age : 23");
                writer.WriteLine("Orange Coding school");
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error : {e.Message}");
            }
        }
        public void ReadFromFile(string fileName)
        {
            try
            {
                StreamReader reader = new StreamReader(fileName);

                string line;
                Console.WriteLine("\nRead info of file:");
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine($"Error : {e.Message}");
            }
        }
        public void CountCharacters(string fileName)
        {
            try
            {
                StreamReader reader = new StreamReader(fileName);

                string content = reader.ReadToEnd();
                int charCount = content.Replace(" ", "").Length;
                Console.WriteLine($"\ntotal number of characters : {charCount}");

            }
            catch (IOException e)
            {
                Console.WriteLine($"Error : {e.Message}");
            }
        }
        public void CountWords(string fileName)
        {
            try
            {
                StreamReader reader = new StreamReader(fileName);

                string content = reader.ReadToEnd();
                string[] words = content.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                int wordCount = words.Length;
                Console.WriteLine($"total number of words : {wordCount}");

            }
            catch (IOException e)
            {
                Console.WriteLine($"Error : {e.Message}");
            }
        }
    }
}
