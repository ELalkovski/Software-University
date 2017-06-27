using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Properties
{
    class Program
    {
        public static double CalculateFaceOfCube(double edgeOfSide)
        {
            return Math.Sqrt(2 * Math.Pow(edgeOfSide, 2));
        }

        public static double CalculateSpaceOfCube(double edgeOfSide)
        {
            return Math.Sqrt(3 * Math.Pow(edgeOfSide, 2));
        }

        public static double CalculateVolumeOfCube(double edgeOfSide)
        {
            return Math.Pow(edgeOfSide, 3);
        }

        public static double CalculateAreaOfCube(double edgeOfSide)
        {
            return Math.Pow(edgeOfSide, 2) * 6;
        }

        public static void PrintResult(double edgeOfSide, string parameter)
        {
            if (parameter == "face")
            {
                Console.WriteLine("{0:f2}", CalculateFaceOfCube(edgeOfSide));
            }
            else if (parameter == "space")
            {
                Console.WriteLine("{0:f2}", CalculateSpaceOfCube(edgeOfSide));
            }
            else if (parameter == "volume")
            {
                Console.WriteLine("{0:f2}", CalculateVolumeOfCube(edgeOfSide)); 
            }
            else if (parameter == "area")
            {
                Console.WriteLine("{0:f2}", CalculateAreaOfCube(edgeOfSide));
            }
        }

        public static void Main(string[] args)
        {
            double edgeOfSide = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            PrintResult(edgeOfSide, parameter);
        }
    }
}
