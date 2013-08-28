using System;

namespace SphericalDistanceCalculator
{
    /// <summary>
    /// An implementation of a spherical distance calculator based on the Law of Cosines
    /// </summary>
    public sealed class LocCalculator : ICalculator
    {
        /// <summary>
        /// Initializes an instance of the <see cref="LocCalculator"/> object.
        /// </summary>
        public LocCalculator() { }

        #region ICalculator Members

        /// <summary>
        /// Calculates the distance between two points on a sphere.
        /// </summary>
        /// <param name="origin">The starting position.</param>
        /// <param name="destination">The destination position.</param>
        /// <returns>A <see cref="Distance"/> object that represents the distance calculated.</returns>
        public Distance Calculate(Coordinate origin, Coordinate destination)
        {
            double longitudeDelta = Math.Abs(destination.Longitude.ToRadians() - origin.Longitude.ToRadians());

            double angularDistance = Math.Acos(Math.Sin(origin.Latitude.ToRadians()) * Math.Sin(destination.Latitude.ToRadians()) + Math.Cos(origin.Latitude.ToRadians()) * Math.Cos(destination.Latitude.ToRadians()) * Math.Cos(longitudeDelta));

            double distance = CalculatorFactory.EarthRadiusInMeters * angularDistance;

            return new Distance(distance);
        }

        #endregion
    }
}
