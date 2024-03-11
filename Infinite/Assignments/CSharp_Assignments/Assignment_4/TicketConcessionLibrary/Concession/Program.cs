using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concession
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter age:");
            int age = int.Parse(Console.ReadLine());

            TicketConcessionLibrary.TicketConcession.CalculateConcession(name, age);

            Console.ReadLine();


            //Lambda expression 1

            Console.WriteLine("Enter a list of numbers:");
            string input = Console.ReadLine();
            List<int> numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToList();

            NumberSquares processor = new NumberSquares();
            List<int> squaresGreaterThan20 = processor.GetSquaresGreaterThan20(numbers);

            Console.WriteLine("Squares greater than 20:");
            foreach (int square in squaresGreaterThan20)
            {
                Console.WriteLine(square);
            }
            Console.ReadLine();

            //Lambda expression 2

            Console.WriteLine("Enter a list of words:");
            string input1 = Console.ReadLine();
            List<string> words = input1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            WordsCollection Output = new WordsCollection();
            List<string> filteredWords = Output.FilterWords(words);

            Console.WriteLine("Words starting with 'a' and ending with 'm':");
            foreach (string word in filteredWords)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();

        }


    }
}
