using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class Sensor
    {
        private List<string> _measureTypes;
        private Dictionary<string, int> _measure;
        public Dictionary<string, int> Measure { get { return _measure; } }

        public Sensor(List<string> input)
        {
            _measureTypes = new List<string>(input);
            _measure = new Dictionary<string, int>();
            Misura();
        }
        public void Misura()
        {


            foreach (string type in _measureTypes)

            {
                var rand = new Random();
                int number = rand.Next(1, 100);
                _measure.Add(type, number);



            }





        }
        public string PrintValues()
        {
            Console.WriteLine(Measure.ToString());
            return Measure.ToString();
        }

        public void Test()
        {
            Console.WriteLine("misurerò: ");
            foreach (var type in _measureTypes)
            {
                Console.WriteLine(type);
            }
            Console.WriteLine();
            Console.WriteLine();
        }


    }
}
