using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_largest_num_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 23, 77, 44, 66, 99, 101, 45, 33, 22, 90 };
            Console.WriteLine("here are the element of an array arr : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]+" ");
            }
            // LOGIC --- ----------------------              ----------------------
            int Max1, Max2;
            Max1 = Max2 = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > Max1)
                {
                    Max2 = Max1;
                    Max1 = arr[i];
                }
                else if (arr[i] > Max2)
                {
                    Max2 = arr[i];
                }
            }
            Console.WriteLine(" \nFirst max num is : " + Max1);
            Console.WriteLine("Second max num is : " + Max2);
            Console.ReadLine();
        }
    }
}