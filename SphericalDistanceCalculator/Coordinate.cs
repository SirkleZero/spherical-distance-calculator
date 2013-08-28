using System;

namespace SphericalDistanceCalculator
{
    public struct Coordinate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinate"/> structure based on the latitude and longitude of a point.
        /// </summary>
        /// <param name="latitude">The latitude of the point in degrees.</param>
        /// <param name="longitude">The longitude of the point in degrees.</param>
        public Coordinate(double latitude, double longitude) : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        /// <summary>
        /// Gets the latitude in degrees.
        /// </summary>
        public double Latitude { get; private set; }

        /// <summary>
        /// Gets the longitude in degrees.
        /// </summary>
        public double Longitude { get; private set; }
    }
}
