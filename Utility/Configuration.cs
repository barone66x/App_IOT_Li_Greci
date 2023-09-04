using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class Configuration
    {

        public string Model { get; set; }
        public int NSensors { get; set; }
        public List<string> MeasuresTypes { get; set; }
        private static Configuration _configuration;
        public static Configuration Configurazione
        {
            get
            {
                if (_configuration == null)
                {
                    _configuration = new Configuration();


                }
                return _configuration;

            }

        }


        public Configuration()
        {
            MeasuresTypes = new List<string>();
        }
        public Configuration ReadConfiguration(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {

                Configurazione.Model = sr.ReadLine();
                Configurazione.NSensors = int.Parse(sr.ReadLine());
                Configurazione.MeasuresTypes = sr.ReadToEnd().Split(Environment.NewLine).ToList();



            }
            return _configuration;
        }
    }
}
