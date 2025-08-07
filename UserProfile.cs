using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class UserProfile
    {
        internal string userName;
        internal string password;
        internal string email;

        internal void GetData()
        {
            Console.Write("Enter username: ");
            userName = Console.ReadLine();

            Console.Write("Enter password: ");
            password = Console.ReadLine();

            Console.Write("Enter email: ");
            email = Console.ReadLine();
        }
        internal void validate_email()
        {
            if (email.Contains("@"))
            {
                Console.WriteLine("valid email address");
            }
            else
            {
                Console.WriteLine("invalid email address");
            }
        }
        internal void validate_password()
        {
            if (password.Length <= 6)
            {
                Console.WriteLine("valid password");
            }
            else
            {
                Console.WriteLine("password must be at least 6 length");
            }
        }
        internal void DisplayData()
        {
            Console.WriteLine($"\nusername:{userName}");
            Console.WriteLine($"\npassword:{password}");
            Console.WriteLine($"\nemail:{email}");
        }
    }
    class Progarm
    {
        internal static void Main(String[] args)
        {
            UserProfile u = new UserProfile();
            u.GetData();
            u.validate_email();
            u.validate_password();
            u.DisplayData();
        }
    }


}
