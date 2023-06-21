using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamlaiBT5
{
    internal class Program
    {
        struct City
        {
            public string cityName;
            public double in1940;
            public double in1950;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("---------------***Enter City Infomation***---------------");
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Enter information of City 1:");
            City City1 = new City();
            Console.Write("Enter City name: ");
            City1.cityName = Console.ReadLine();
            Console.Write("Enter population in 1940: ");
            City1.in1940 = Double.Parse(Console.ReadLine());
            Console.Write("Enter population in 1950: ");
            City1.in1950 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter information of City 2:");
            City City2 = new City();
            Console.Write("Enter City name: ");
            City2.cityName = Console.ReadLine();
            Console.Write("Enter population in 1940: ");
            City2.in1940 = Double.Parse(Console.ReadLine());
            Console.Write("Enter population in 1950: ");
            City2.in1950 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter information of City 3:");
            City City3 = new City();
            Console.Write("Enter City name: ");
            City3.cityName = Console.ReadLine();
            Console.Write("Enter population in 1940: ");
            City3.in1940 = Double.Parse(Console.ReadLine());
            Console.Write("Enter population in 1950: ");
            City3.in1950 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter information of City 4:");
            City City4 = new City();
            Console.Write("Enter City name: ");
            City4.cityName = Console.ReadLine();
            Console.Write("Enter population in 1940: ");
            City4.in1940 = Double.Parse(Console.ReadLine());
            Console.Write("Enter population in 1950: ");
            City4.in1950 = Double.Parse(Console.ReadLine());

            double changesCity1 = ((City1.in1950 - City1.in1940) / City1.in1940) * 100.0;
          
            double changesCity2 = ((City2.in1950 - City2.in1940) / City2.in1940) * 100.0;
            double changesCity3 = ((City3.in1950 - City3.in1940) / City3.in1940) * 100.0;
            double changesCity4 = ((City4.in1950 - City4.in1940) / City4.in1940) * 100.0;

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("---------------***Show City Infomation***---------------");
            Console.WriteLine("{0, -20} {1, 0} {2, 15} {3, 15} {4, 15} {5, 20}", "city", "year", "population", "year", "population", "changes(%)");
            Console.WriteLine("{0, -20} {1, 0} {2, 15} {3, 15} {4, 15} {5, 20}", City1.cityName , "1940", City1.in1940 , "1950", City1.in1950, String.Format("{0:0.00}", changesCity1));
            Console.WriteLine("{0, -20} {1, 0} {2, 15} {3, 15} {4, 15} {5, 20}", City2.cityName, "1940", City2.in1940, "1950", City2.in1950, String.Format("{0:0.00}", changesCity2));
            Console.WriteLine("{0, -20} {1, 0} {2, 15} {3, 15} {4, 15} {5, 20}", City3.cityName, "1940", City3.in1940, "1950", City3.in1950, String.Format("{0:0.00}", changesCity3));
            Console.WriteLine("{0, -20} {1, 0} {2, 15} {3, 15} {4, 15} {5, 20}", City4.cityName, "1940", City4.in1940, "1950", City4.in1950, String.Format("{0:0.00}", changesCity4));

            Console.ReadKey();
        }
    }
}
