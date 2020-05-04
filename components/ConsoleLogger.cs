using System;
using System.Collections.Generic;
using System.Text;

namespace lv5analiza.components
{
    class ConsoleLogger
    {
        public static ConsoleLogger instance;
        DateTime date;

        private ConsoleLogger()
        {
            this.date = DateTime.Now;
        }

        public static ConsoleLogger GetInstance()
        {
            if (instance == null)
            {
                instance = new ConsoleLogger();
            }
            return instance;
        }

        public void Log(string message)
        {
            Console.WriteLine(message + " " + date);
        }
    }
}
