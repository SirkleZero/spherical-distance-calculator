using System;

namespace SphericalDistanceCalculator
{
    /// <summary>
    /// An implementation of a spherical distance calculator based a special case of the Vincenty formula.
    /// </summary>
    public sealed class Arctan2Calculator : ICalculator
    {
        /// <summary>
        /// Initializes an instance of the <see cref="Arctan2Calculator"/> object.
        /// </summary>
        public Arctan2Calculator() { }

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

            double numerator = Math.Sqrt(Math.Pow(Math.Cos(destinationLatitudeRadians) * Math.Sin(longitudeDelta), 2) + Math.Pow(Math.Cos(originLatitudeRadians) * Math.Sin(destinationLatitudeRadians) - Math.Sin(originLatitudeRadians) * Math.Cos(destinationLatitudeRadians) * Math.Cos(longitudeDelta), 2));
            double denominator = Math.Sin(originLatitudeRadians) * Math.Sin(destinationLatitudeRadians) + Math.Cos(originLatitudeRadians) * Math.Cos(destinationLatitudeRadians) * Math.Cos(longitudeDelta);

            double angularDistance = Math.Atan2(numerator, denominator);

            double distance = CalculatorFactory.EarthRadiusInMeters * angularDistance;

            return new Distance(distance);
        }

        #endregion
    }
}
