using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 6, 7, 8, 5, 4, 3, 1, 9,10 };

            //Select select = new Select();
            //select.SelectSort(array);

            //Insertion insertion = new Insertion();
            //insertion.InsertionSort(array);

            Merge merge = new Merge();
            merge.merge_sort(array, 1, 10);

            Console.WriteLine(string.Join(",", array));
            Console.ReadLine();
        }
    }
}
