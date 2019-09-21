using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace gitWsb
{
    class Program
    {
        const string UsersFile = "user.txt";
        const string BooksFile = "books.txt";
        static void Main(string[] args)
        {

            string id;
            string password;
            if (!File.Exists(UsersFile))
                throw new Exception("Cannot find user.txt!");
            if (!File.Exists(BooksFile))
                throw new Exception("Cannot find book.txt!");

            //Console.WriteLine("Login:");
            //id = Console.ReadLine();
            //Console.WriteLine("Password:");
            //password = Console.ReadLine();

            StreamReader sr = new StreamReader("user.txt");
            string file = sr.ReadToEnd();

            string[] user = file.Split('\n');
            string[] login = user[0];//.Split('\r');

            Console.ReadKey();
        }
    }
    class User
    {
        string Id;
        string Password;
    }
}
