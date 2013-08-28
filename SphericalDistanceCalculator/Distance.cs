using System;

namespace SphericalDistanceCalculator
{
    public struct Distance
    {
        public const double MilesToMetersRatio = 0.00062137;
        public const int MetersToKilometersRatio = 1000;

        public Distance(double meters) : this()
        {
            this.Meters = meters;
        }

        public double Meters { get; private set; }

        public double ToKilometers()
        {
            return this.Meters / Distance.MetersToKilometersRatio;
        }

        public double ToMiles()
        {
            return this.Meters * Distance.MilesToMetersRatio;
        }
    }
}
