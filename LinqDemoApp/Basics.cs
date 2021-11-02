using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemoApp
{
    static class Basics
    {
        static int[] scores = { 55, 45, 33, 56, 77, 89, 54, 31, 99, 87, 2, 3, 4, 5, 67, 97, 88, 100, 93 };
        static public void Run()
        {
            foreach (var item in scores)
            {
                Console.WriteLine(item);
            }
            var theBest = from item in scores where item > 90 select item;
            Console.WriteLine("Bests");
            foreach (var item in theBest)
            {
                Console.WriteLine(item);
            }
            var sortedScore = from item in scores orderby item descending select item;
            Console.WriteLine("Sorted");
            foreach (var item in sortedScore)
            {
                Console.WriteLine(item);
            }
            var bStudents = from item in scores where item >= 80 where item <= 89 orderby item select item;
            Console.WriteLine("B Students");
            foreach (var item in bStudents)
            {
                Console.WriteLine(item);
            }
        }
            
    }
}
