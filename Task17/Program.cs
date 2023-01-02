using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            Account<int> account1 = new Account<int>();
            account1.Input();
            Console.WriteLine(account1.Print());
            Account<string> account2 = new Account<string>();
            account2.Input();
            Console.WriteLine(account2.Print());
            Console.ReadKey();
        }
    }
}
