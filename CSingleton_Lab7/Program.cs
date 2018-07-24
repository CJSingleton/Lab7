using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSingleton_Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            //First and Last Name: ^[A-Z]{1}[a-zA-Z]{1,14}\s[A-Z]{1}[a-zA-Z]{1,15}$
            //Emails: ^[a-zA-Z\d]{5,30}@[a-zA-Z\d]{5,10}\.[a-zA-Z\d]{2,3}$
            //Phone Numbers: ^[\d]{3}-[\d]{3}-[\d]{4}$
            //Date (dd/mm/yyyy): ^[\d]{2}\/[\d]{2}\/[\d]{4}$
            
            Console.WriteLine("Please enter a valid first and last name:");
            string namein = Console.ReadLine();
            name(namein);

            Console.WriteLine("Please enter a valid email:");
            string emailin = Console.ReadLine();
            email(emailin);

            Console.WriteLine("Please enter a valid phone number:");
            string phonein = Console.ReadLine();
            phonenumber(phonein);

            Console.WriteLine("Please enter a valid date:");
            string datein = Console.ReadLine();
            date(datein);

        }
        static string name(string input)
        {
            while (!Regex.IsMatch(input, @"^[A-Z]{1}[a-zA-Z]{1,14}\s[A-Z]{1}[a-zA-Z]{1,15}$"))
            {
                Console.WriteLine("This is invalid. Please try again.");
                Console.WriteLine("Please enter a valid name:");
                string name = Console.ReadLine();
            }
            Console.WriteLine("You have entered a valid name!");
            return input;
        }
        static string email(string input)
        {
            while (!Regex.IsMatch(input, @"^[a-zA-Z\d\.]{5,30}@[a-zA-Z\d]{5,10}\.[a-zA-Z\d]{2,3}$"))
            {
                Console.WriteLine("This is invalid. Please try again.");
                Console.WriteLine("Please enter a valid email address:");
                string email = Console.ReadLine();
            }
            Console.WriteLine("You have entered a valid email!");
            return input;
        }
        static string phonenumber(string input)
        {
            while (!Regex.IsMatch(input, @"^[\d]{3}-[\d]{3}-[\d]{4}$"))
            {
                Console.WriteLine("This is invalid. Please try again.");
                Console.WriteLine("Please enter a valid phone number:");
                string phonenumber = Console.ReadLine();
            }
            Console.WriteLine("You have entered a valid phone number!");
            return input;
        }
        static string date(string input)
        {
            while (!Regex.IsMatch(input, @"^[\d]{2}\/[\d]{2}\/[\d]{4}$"))
            {
                Console.WriteLine("This is invalid. Please try again.");
                Console.WriteLine("Please enter a valid date:");
                string date = Console.ReadLine();
            }
            Console.WriteLine("You have entered a valid date!");
            return input;
        }
    }
}
