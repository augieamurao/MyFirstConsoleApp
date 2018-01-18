using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");

            Messenger msg = new Messenger("Hello Augie");
            msg.author = "Cindy";

            Console.WriteLine(msg.SayHello());
            Console.ReadLine();
        }
    }
    class Messenger
    {
        private string message;
        public string author { get; set; }

        public Messenger(string msg)
        {
            message = msg;
            return;
        }
        public string SayHello()
        {
            return message + " from " + author;
        }
    }
}
