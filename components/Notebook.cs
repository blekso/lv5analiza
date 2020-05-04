using System;
using System.Collections.Generic;
using System.Text;

namespace lv5analiza.components
{
    class Notebook
    {
        private List<ReminderNote> notes;
        private ITheme theme;
        public Notebook(ITheme theme) { 
            this.notes = new List<ReminderNote>();
            this.theme = theme;

        }
        public void AddNote(ReminderNote note)
        {
            this.notes.Add(note);
        }
        public void AddNote(ReminderNote note, ITheme theme) 
        {
            note.Theme = theme;
            this.notes.Add(note);
        }
        public void ChangeTheme(ITheme theme)
        {
            foreach (ReminderNote note in this.notes)
            {
                note.Theme = theme;
            }
        }
        public void Display()
        {
            foreach (ReminderNote note in this.notes)
            {
                note.Show();
                Console.WriteLine("\n");
            }
        }
    }
}
