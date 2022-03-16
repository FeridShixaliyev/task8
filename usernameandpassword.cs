using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string username = "";
            string password;
            User user = new User(username);
            do
            {
                Console.Write("Istifadeci adini daxil edin: ");
                username = Console.ReadLine();
                user.Username = username;
                if (user.Username == null)
                    Console.WriteLine("Istifadeci adi en azi 6,en coxu 25 simboldan ibaret ola biler  ");
            } while (user.Username == null);
            do
            {
                Console.Write("Sifreni daxil edin: ");
                password = Console.ReadLine();
                user.Password = password;
                if (user.Password == null)
                    Console.WriteLine("Sifre en azi 8,en coxu 25 simboldan ibaret ola biler  ");
            } while (user.Password == null);


        }
    }
}
