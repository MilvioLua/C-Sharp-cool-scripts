using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public  class User
    {
        public User()
        {

        }
        public User(string fristname, string secondname)
        {
            FristName = fristname;
            LastName = secondname;
        }
        public bool Verified { get; set; } = false;
        public string FulName {
            get
            {
                return FristName + " " + LastName; 
            }
            set {
            } 
        }
        public string FristName { get; }
        public string LastName { get;}

        virtual public void WriteToConsole (){
            Console.WriteLine("hello user my name is : " + FulName);
        
        }
    }
}
