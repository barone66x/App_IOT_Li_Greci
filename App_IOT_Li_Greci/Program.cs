using System;
using Utility;

namespace App_IOT_Li_Greci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //fare interface con metodi comuni (Print e readConfiguration)
            //fare 4 file di configurazione

            //fare classi derivate da interface
            //fare metodo readConfiguration
            //guardare documentazione per metodo random
            //creare metodi print personalizzati
            //Fare metodo Send
            string path1 = @"C:\Users\mattia.ligreci\Documents\Test\Iot\configEntry.txt";
            string path2 = @"C:\Users\mattia.ligreci\Documents\Test\Iot\configPro1.txt";
            string path3 = @"C:\Users\mattia.ligreci\Documents\Test\Iot\configPro2.txt";
            string path4 = @"C:\Users\mattia.ligreci\Documents\Test\Iot\configSuper.txt";
            Configuration c1 = new Configuration();
            c1 = c1.ReadConfiguration(path4);

            Device e1 = new Device(c1);
            //Pro1 pro1 = new Pro1();
            //Pro2 pro2 = new Pro2();
            //Super super1 = new Super();

            // e1.ReadConfig(path4);
            e1.Start();
            e1.Print();





        }
    }
}
