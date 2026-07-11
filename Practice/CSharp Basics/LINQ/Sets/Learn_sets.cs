using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.LINQ.Sets
{
    internal class Learn_sets
    {
        public static void Run()
        {
            List<int> num1 = new List<int>() { 1, 2, 3, 4, 5, 5};
            List<int> num2 = new List<int>() { 4, 5, 6, 7, 8 };

            //var distinct does not contain the actual elements instead what it contain is.
            //It contains the information (logic) needed to produce the elements. So it returns the value when a forloop is iterated. 
            var distinct = num1.Distinct();
            foreach (int n in distinct) 
            {
                Console.WriteLine(distinct);
            }

            //Union() combines two collections and removes duplicate elements.
            var union = num1.Union(num2);
            Console.WriteLine("Union");
            foreach (var item in union)
            {
                Console.Write(item + " ");
            }

            // Concat() combines two collections without removing duplicates.
            var concatResult = num1.Concat(num2);
            Console.WriteLine("Concat");
            foreach (var item in concatResult)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            // Intersect() returns only the elements that exist in both collections.
            var intersectResult = num1.Intersect(num2);
            Console.WriteLine("Intersect");
            foreach (var item in intersectResult)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            // Except() returns elements that exist in the first collection but not in the second.
            var exceptResult = num1.Except(num2);
            Console.WriteLine("Except");
            foreach (var item in exceptResult)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            // SequenceEqual() checks whether two collections have the same elements in the same order.
            var sequenceEqual = num1.SequenceEqual(num2);
            Console.WriteLine(sequenceEqual);


        }
    }
}
