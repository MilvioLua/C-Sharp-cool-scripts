using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Student : User , Italk
    {

        public Student(string fristname, string secondname) : base (fristname, secondname)       
        {
          
        }

        public int test { get; set ; }

        public override void WriteToConsole()
        {
            Console.WriteLine("hi i am a student my name is" + FulName.ToUpper());
        }
    }
}
