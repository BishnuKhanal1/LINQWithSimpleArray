using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQWithSimpleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = new[] {2, 9, 5, 0,3, 7, 1, 4, 8, 5};
            //display orginal values
            Console.WriteLine("Originl Array Values: ");
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            //LINQ queries that obtains values greater then 4 from the array
            var filtered =
                from value in values
                where value > 4 
                select value;

            Console.WriteLine("Displaying values greater than 4: ");
            //display filtered/selected value
            foreach (var item in filtered)
            {
                Console.WriteLine(item);
            }

            //use orderby clause to orginal values in ascedning order
            var sorted = from value in values
                         orderby value ascending //also by default they are in ascending order
                         select value;

            //displaying sorted value
            Console.WriteLine("Displaying values in ascending order: ");
            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }

            //sorted filtered result in descedning order
            var sortedDescending =
                from value in values
                orderby value descending
                select value;

            //displaying sorted values in discending order
            Console.WriteLine("Sorted values in discending values: ");
            foreach (var item in sortedDescending)
            {
                Console.WriteLine(item);
            }
        }
    }
}
