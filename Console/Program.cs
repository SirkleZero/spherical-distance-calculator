using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SphericalDistanceCalculator;

namespace Console
{
    class Harness
    {
        static void Main(string[] args)
        {
            var factory = new CalculatorFactory();
            var calculator = factory.Create(Algorithm.Arctan2);

            // http://www.findlatitudeandlongitude.com/
            var origin = new Coordinate(43.089325, -87.87406);
            var destination = new Coordinate(43.060109, -87.883759);

            var distance1 = calculator.Calculate(origin, destination);

            calculator = factory.Create(Algorithm.Haversine);
            var distance2 = calculator.Calculate(origin, destination);

            calculator = factory.Create(Algorithm.LawOfCosines);
            var distance3 = calculator.Calculate(origin, destination);

            System.Console.WriteLine("arctan2:\t{0}", distance1.Meters);
            System.Console.WriteLine("haversine:\t{0}", distance2.Meters);
            System.Console.WriteLine("law of cosines:\t{0}", distance3.Meters);

            System.Console.ReadLine();
        }
    }
}
