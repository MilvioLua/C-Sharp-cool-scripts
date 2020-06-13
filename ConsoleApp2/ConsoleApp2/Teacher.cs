using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Teacher : User 
    {
        public override void WriteToConsole()
        {
            Console.WriteLine("I a teacher my nae is : " + FulName);
        }
    }
}
