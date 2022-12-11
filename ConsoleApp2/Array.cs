using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Array
    {
        public static void TestArray()
        {
            Console.WriteLine("Please Enter size of Array");
            int size=Convert.ToInt32(Console.ReadLine());
            int[] numbers= new int[size];
            Console.WriteLine("Reading input from Users and storing in an array");
            for (int i=0; i<size; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());           
            }
            Console.WriteLine("Displaying array elements");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i] + " ");
            }
            Console.WriteLine("/n Updating value of 3rd element please enter the number");
            numbers[2]=Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]+" ");
            }
            
        }
    }
}
