using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    class MessageRegex
    {
        static string message = "Hello <<name>>, We have your full name as <<full name>> in our system.Your contact number is 91-xxxxxxxxxx.Please, let us know in case of any clarification Thank you BridgeLabz 01/01/2016 .";
        public static void MatchandReplace()
        {
            string namePattern = "^[<]{2}name[>]{2}";
            string fullNamePattern = "^[<]{2}full name[>]{2}";
            string phoneNumberPattern = "^[x]{10}";
            string date = "^[01]+[/]+[01]+[/]+[2016]";
            Regex regex = new Regex(namePattern);
            Regex regexFullName = new Regex(fullNamePattern);
            Regex regexPhone = new Regex(phoneNumberPattern);
            Regex regexDate = new Regex(date);
            if (regex.IsMatch("<<name>>"))
            {
                Console.WriteLine("Enter the name:");
                string name = Console.ReadLine();
                message = message.Replace("<<name>>",name);
            }
            if (regexFullName.IsMatch("<<full name>>"))
            {
                Console.WriteLine("Enter the full name:");
                string fullname = Console.ReadLine();
                message = message.Replace("<<full name>>", fullname);
            }
            if (regexPhone.IsMatch("xxxxxxxxxx"))
            {
                Console.WriteLine("Enter the Phone Number");
                string phone = Console.ReadLine();
                message = message.Replace("xxxxxxxxxx", phone);
            }
            if (regexDate.IsMatch("01/01/2016"))
            {
                string curdate = DateTime.Now.ToString("dd/MM/yyyy");
                message = message.Replace("01/01/2016", curdate);

            }
            Console.WriteLine("The Message :");

            Console.WriteLine(message);
            Console.WriteLine(" ");
        }
    }
}
