using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class User
    {

        public string FulName {
            get
            {
                return FristName + " " + LastName; 
            }
            set {
            } 
        }
        public string FristName { get; set; }
        public string LastName { get; set; }


        public string Output(int times = 5)
        {
            string message = "";
            for (int i = 0; i < times; i++)
                message += FristName + " " + LastName;
            return message;
        }

        public static void PrintUsers(List<User> users) 
        { 

        }
    }
}
