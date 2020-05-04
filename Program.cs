using lv5analiza.components;
using System;
using System.Collections.Generic;

namespace lv5analiza
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadatak1_2();
            //Zadatak3_4();
            //Zadatak5();
            //Zadatak6();
            Zadatak7();
        }

        static void Zadatak1_2()
        {
            IShipable item1 = new Product("opis", 1.53, 5);
            IShipable item2 = new Product("opisopis", 3, 6);
            Box box = new Box("kutija");
            box.Add(item1);
            box.Add(item2);
            ShippingService service = new ShippingService(3);
            Console.WriteLine(service.CalculateShipping(box));
        }
        static void Zadatak3_4()
        {
            string filepath = @"file.csv";
            VirtualProxyDataset virtualProxyDataset = new VirtualProxyDataset(filepath);
            DataConsolePrinter dataPrinter = new DataConsolePrinter();
            dataPrinter.DisplayItems(virtualProxyDataset);

            ProtectionProxyDataset protectedProxyDataset = new ProtectionProxyDataset(User.GenerateUser("Mihael"));
            dataPrinter.DisplayItems(protectedProxyDataset);

            LoggerProxyDataset loggerProxyDataset = new LoggerProxyDataset(filepath);
            dataPrinter.DisplayItems(loggerProxyDataset);
        }

        static void Zadatak5()
        {
            DarkTheme darkTheme = new DarkTheme();
            ReminderNote note = new ReminderNote("buy milk lol", darkTheme);
            note.Show();
        }

        static void Zadatak6()
        {
            DarkTheme darkTheme = new DarkTheme();
            LightTheme lightTheme = new LightTheme();
            ReminderList list1 = new ReminderList("buy more milk plz", darkTheme);
            list1.AddToList("mihael");
            list1.AddToList("bilo ko drugi");
            list1.Show();

            ReminderList list2 = new ReminderList("get work done", lightTheme);
            list2.AddToList("mihael");
            list2.AddToList("somebodyelse");
            list2.Show();
        }

        static void Zadatak7()
        {
            DarkTheme darkTheme = new DarkTheme();
            LightTheme lightTheme = new LightTheme();

            ReminderNote note1 = new ReminderNote("buy milk lol", lightTheme);
            ReminderNote note2 = new ReminderNote("buy milk again lol", darkTheme);

            Notebook notebook = new Notebook(darkTheme);
            notebook.AddNote(note1, lightTheme);
            notebook.AddNote(note2);
            notebook.Display();
        }
    }
}
