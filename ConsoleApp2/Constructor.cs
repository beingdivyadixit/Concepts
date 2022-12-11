using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Constructor
    {  
         public Constructor()
        {
            Console.WriteLine("Default constructor");
        }
        //Paramitrized constructor
        public Constructor(int Phone)
        {
            Console.WriteLine("Paramitrized constructor");
        }
        // Local variable - Scope is only to method
        public static void StudentAge(int phoneNumber)
        {
            int age = 0;
            age = age + 10;
            Console.WriteLine("Student age is {0} and phonenumber is {1}:",age,phoneNumber);
        }
    }
}
