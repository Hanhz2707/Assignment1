using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Logger
    {
        private Logger() { }
        private static Logger instance;

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
        public void Log(string message)
        {
            Console.WriteLine(message);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
           

            logger1.Log("Hello ITMI21SP");
            
        }
    }
}
