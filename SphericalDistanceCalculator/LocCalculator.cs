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
            // calculate the longitude delta in absolute radians
            double longitudeDelta = Math.Abs(destination.Longitude.ToRadians() - origin.Longitude.ToRadians());

            // convert the latitudes to radians
            double originLatitudeRadians = origin.Latitude.ToRadians();
            double destinationLatitudeRadians = destination.Latitude.ToRadians();

            double angularDistance = Math.Acos(Math.Sin(originLatitudeRadians) * Math.Sin(destinationLatitudeRadians) + Math.Cos(originLatitudeRadians) * Math.Cos(destinationLatitudeRadians) * Math.Cos(longitudeDelta));

            double distance = CalculatorFactory.EarthRadiusInMeters * angularDistance;

            return new Distance(distance);
        }

        #endregion
    }
}
