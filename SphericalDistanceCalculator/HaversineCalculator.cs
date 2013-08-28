using System;

namespace SphericalDistanceCalculator
{
    /// <summary>
    /// An implementation of a spherical distance calculator based on the Haversine function.
    /// </summary>
    public sealed class HaversineCalculator : ICalculator
    {
        /// <summary>
        /// Initializes an instance of the <see cref="HaversineCalculator"/> object.
        /// </summary>
        public HaversineCalculator() { }

        #region ICalculator Members

        /// <summary>
        /// Calculates the distance between two points on a sphere.
        /// </summary>
        /// <param name="origin">The starting position.</param>
        /// <param name="destination">The destination position.</param>
        /// <returns>A <see cref="Distance"/> object that represents the distance calculated.</returns>
        public Distance Calculate(Coordinate origin, Coordinate destination)
        {
            double latitudeDelta = Math.Abs(destination.Latitude.ToRadians() - origin.Latitude.ToRadians());
            double longitudeDelta = Math.Abs(destination.Longitude.ToRadians() - origin.Longitude.ToRadians());

            double a = Math.Pow(Math.Sin(latitudeDelta / 2), 2) + Math.Cos(origin.Latitude.ToRadians()) * Math.Cos(destination.Latitude.ToRadians()) * Math.Pow(Math.Sin(longitudeDelta / 2), 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            double distance = CalculatorFactory.EarthRadiusInMeters * c;

            return new Distance(distance);
        }

        #endregion
    }
}
