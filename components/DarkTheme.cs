using System;
using System.Collections.Generic;
using System.Text;

namespace lv5analiza.components
{
    class DarkTheme : ITheme
    {
        public void SetBackgroundColor()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
        }
        public void SetFontColor()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        public string GetHeader(int width)
        {
            return new string('+', width);
        }
        public string GetFooter(int width)
        {
            return new string('_', width);
        }
    }
}
