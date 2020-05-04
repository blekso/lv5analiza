using System;
using System.Collections.Generic;
using System.Text;

namespace lv5analiza.components
{
    class ReminderList : Note
    {
        private List<string> list;
        public ReminderList(string message, ITheme theme) : base(message, theme) {
            this.list = new List<string>();
        }

        public void AddToList(string person)
        {
            list.Add(person);
        }

        public void RemoveFromList(string person)
        {
            list.Remove(person);
        }

        private void PrintList()
        {
            Console.WriteLine("Needed People: ");
            foreach(string note in list)
            {
                Console.Write(note + ", ");
            }
        }
        public override void Show()
        {
            this.ChangeColor();
            Console.WriteLine("REMINDER: ");
            string framedMessage = this.GetFramedMessage();
            Console.WriteLine(framedMessage);
            this.PrintList();
            Console.WriteLine();
            Console.ResetColor();
        }
    }

}
