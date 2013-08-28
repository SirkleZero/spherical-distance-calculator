using System;

namespace SphericalDistanceCalculator
{
    public class CalculatorFactory
    {
        public const double EarthRadiusInMeters = 6378137.0;

        public CalculatorFactory() { }

        public ICalculator Create(Algorithm type)
        {
            switch (type)
            {
                case Algorithm.Arctan2:
                    return new Arctan2Calculator();
                case Algorithm.Haversine:
                    return new HaversineCalculator();
                case Algorithm.LawOfCosines:
                    return new LocCalculator();
                default:
                    return new Arctan2Calculator();
            }
        }
    }
}
