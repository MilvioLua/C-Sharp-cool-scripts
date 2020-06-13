using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        { 
            Program myProgram = new Program();
            myProgram.doSomething();

        }

        public void doSomething()
        {
            User user = new User();
            user.FristName = "milvio";
            user.LastName = "chivinda";

        } 

    } 
} 
