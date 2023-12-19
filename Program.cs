using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            names.Add("Lee");
            names.Add("Lesedi");
            names.Add("Les");
            names.Add("Sedi");

            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);

            Console.ReadLine();
        }
    }
}
