using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;

namespace LinqPocketReference
{
    internal class Program
    {
        public static void GettingStarted()
        {
            string[] names = { "Tom", "Dick", "Harry" };
            IEnumerable<string> filteredNames = System.Linq.Enumerable.Where(names, n => n.Length >= 4);
            foreach (string n in filteredNames)
                Console.Write(n + "|");
            Console.WriteLine("");
            filteredNames =
                from n in names
                where n.Contains("a")
                select n;
            foreach (string n in filteredNames)
                Console.Write(n + "|");
            Console.WriteLine("");
        }
        public static void LambdaQueries()
        {
            string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
            IEnumerable<string> query0 = names
                .Where(n => n.Contains("a"))
                .OrderBy(n => n.Length)
                .Select(n => n.ToUpper());
            foreach (string name in query0)
                Console.Write(name + "|");
            Console.WriteLine("");
            var filtered = names.Where(n => n.Contains("a"));
            var sorted = filtered.OrderBy(n => n.Length);
            var finalQuery = sorted.Select(n => n.ToUpper());
            foreach (string name in filtered)
                Console.Write(name + "|");
            Console.WriteLine("");
            foreach (string name in sorted)
                Console.Write(name + "|");
            Console.WriteLine("");
            foreach (string name in finalQuery)
                Console.Write(name + "|");
            Console.WriteLine("");
            IEnumerable<int> query1 = names.Select(n => n.Length);
            foreach (int length in query1)
                Console.Write(length);
            Console.WriteLine("");
            int[] numbers = { 10, 9, 8, 7, 6, };
            int firstNumber = numbers.First();
            int lastNumber = numbers.Last();
            int seconndNumber = numbers.ElementAt(1);
            int count = numbers.Count();
            int min = numbers.Min();
            bool hasTheNumberNine = numbers.Contains(9);
            bool hasMoreThanZeroElements = numbers.Any();
            bool hasAnOddElement = numbers.Any(n => n % 2 == 1);
            Console.WriteLine($"{firstNumber}|{lastNumber}|{seconndNumber}|{count}|{min}");
            Console.WriteLine($"{hasTheNumberNine}|{hasMoreThanZeroElements}|{hasAnOddElement}");
        }
        public static void ComprehensionQueries()
        {
            string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
            IEnumerable<string> query0 =
                from n in names
                where n.Contains("a")
                orderby n.Length
                select n.ToUpper();
            foreach (string name in query0)
                Console.Write(name + "/");
            Console.WriteLine("");
            IEnumerable<string> query1 = names
                .Where(n => n.Contains("a"))
                .OrderBy(n => n.Length)
                .Select(n => n.ToUpper());
            foreach (string name in query1)
                Console.Write(name + "|");
            Console.WriteLine("");
            int count = (
                from name in names
                where name.Contains("a")
                select name
            ).Count();
            Console.WriteLine(count);
        }
        public static void DeferredExecution()
        {
            var numbers = new List<int>();
            numbers.Add(1);
            IEnumerable<int> query0 = numbers.OrderBy(n => n * 10);
            numbers.Add(2);
            foreach (int n in query0)
                Console.Write(n + "|");
            int matches = numbers.Where(n => n > 1).Count();
            Console.WriteLine(matches);
            numbers = new List<int>() {1, 2};
            IEnumerable<int> query1 = numbers.Select(n => n * 10);
            foreach (int n in query1)
                Console.Write(n + "|");
            numbers.Clear();
            foreach (int n in query1)
                Console.Write(n + "|");
            Console.WriteLine("");
            numbers = new List<int>() {1, 2};
            List<int> timesTen = numbers.Select(n => n * 10).ToList();
            numbers.Clear();
            Console.WriteLine(timesTen.Count);
            int[] numbers1 = {1, 2};
            int factor = 10;
            var query2 = numbers1.Select(n => n * factor);
            factor = 20;
            foreach (int n in query0)
                Console.Write(n + "|");
            Console.WriteLine("");
            IEnumerable<char> query3 = "Not what you might expect";
            foreach (char vowel in "aeiou"){
                char temp = vowel;
                query3 = query3.Where(c => c != temp);
                Console.Write(query3.First()+"|");
            }
            Console.WriteLine("");
            IEnumerable<int> lessThenTen = new int[] {5, 12, 3}.Where(n => n < 10);
            foreach (int n in lessThenTen)
                Console.Write(n + "|");
            Console.WriteLine("");
            IEnumerable<int> query4 = new int[] {5, 12, 3}.Where(n => n < 10).OrderBy(n => n).Select(n => n * 10);
            foreach (int n in query4)
                Console.Write(n + "|");
            Console.WriteLine("");
            IEnumerable<int>
                source = new int[] {5, 12, 3,},
                filtered = source.Where(n => n < 10),
                sorted = filtered.OrderBy(n => n),
                query5 = sorted.Select(n => n * 10);
            foreach (int n in query5)
                Console.Write(n + "|");
            Console.WriteLine("");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Getting Started");
            GettingStarted();
            Console.WriteLine("Lambda Queries");
            LambdaQueries();
            Console.WriteLine("Comprehension Queries");
            ComprehensionQueries();
            Console.WriteLine("Deferred Execution");
            DeferredExecution();
        }
    }
}
