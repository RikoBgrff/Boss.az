using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Boss.az
{
    class Program
    {


        static void StartPanel()
        {
            Console.WriteLine("Create new account:1");
            Console.WriteLine("Log  in:2");
            Console.Write("Your Choice:");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("Worker:1");
                Console.WriteLine("Employer:2");
                Console.Write("Your Choice:");
                string workerOrEmployer = Console.ReadLine();
                Thread.Sleep(2000);
                Console.Write("Name:"); string name = Console.ReadLine();
                Console.Write("Surname:"); string surname = Console.ReadLine();
                Console.Write("City:"); string city = Console.ReadLine();
                Console.Write("Phone:"); string phone = Console.ReadLine();
                Console.Write("Age:"); string forAge = Console.ReadLine();
                int age = Convert.ToInt32(forAge); 
                if (workerOrEmployer == "1") 
                {
                    
                }
                if(workerOrEmployer == "2")
                {
                    //employer
                }
            }
            if (choice == "2")
            {
                //login
            }
        }
        static void Main(string[] args)
        {
            StartPanel();
            
           

        }
    }
}
