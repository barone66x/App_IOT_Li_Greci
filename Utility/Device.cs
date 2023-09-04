using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class Device
    {
        public int NSensors { get; set; }
        public string Model { get; set; }

        private List<string> _contents = null;
        // private Dictionary<string, int> _measures = null;
        private List<Sensor> _sensors;

        public Device(Configuration c)
        {
            NSensors = c.NSensors;
            Model = c.Model;
            _sensors = new List<Sensor>();
            _contents = new List<string>();
            _contents = c.MeasuresTypes;

        }

        public void Print()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Number of Sensors: {NSensors}");


            foreach (Sensor sensor in _sensors)
            {
                foreach (var measure in sensor.Measure)
                {
                    Console.WriteLine($"{measure.Key}  :  {measure.Value}");
                }
            }
        }

        public void ReadConfig(string path)
        {
            Console.WriteLine("misurerò: ");
            _contents = File.ReadLines(path).ToList();
            foreach (string line in _contents)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine();
            Console.WriteLine();
            //foreach (string line in _contents) 
            //{


            //}

        }
        public void Start()
        {

            for (int i = 0; i < NSensors; i += 1)
            {
                _sensors.Add(new Sensor(_contents));
                //Sensor s = new Sensor(_contents);
                // s1.Test();



            }

        }


    }
}
