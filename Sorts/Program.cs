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
            int[] array = { 2, 6, 7, 8, 5, 4, 3, 1, 9 };

            //Select select = new Select();
            //select.SelectSort(array);

            Insertion insertion = new Insertion();
            insertion.InsertionSort(array);
            
            Console.WriteLine(string.Join(",", array));
            Console.ReadLine();
        }
    }
}
