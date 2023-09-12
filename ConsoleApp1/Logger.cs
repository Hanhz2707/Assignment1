using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Creating Logger class
    public class Logger
    {
        private Logger() { }
        private static Logger instance;

        //Implementing Singleton pattern
        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
        //Adding a public method with a string as an agrument
        public void Log(string message)
        {
            Console.WriteLine(message);
        }

    }
    class Program
    {
        //Logger class was called in the main method
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
           

            logger1.Log("Hello ITMI21SP");
            
        }
    }
}
