using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {    
            //Constructor.StudentAge(147663686);
            //Constructor constructor= new Constructor();
            //Constructor constructor2= new Constructor(546);
            Instantce marks= new Instantce();
            marks.engMarks = 85;
            marks.mathsMarks = 98;
            marks.phyMarks = 90;
            marks.MarksDetails();
            Instantce marks1= new Instantce();
            marks1.engMarks = 80;
            marks1.mathsMarks = 95;
            marks1.phyMarks = 88;
            marks1.MarksDetails();
            
        }
    }
}
