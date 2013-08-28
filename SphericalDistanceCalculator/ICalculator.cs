using System;

namespace SphericalDistanceCalculator
{
    /// <summary>
    /// Specifies an interface that declares distance calculator functionality.
    /// </summary>
    public interface ICalculator
    {
        /// <summary>
        /// Calculates the distance between two points on a sphere.
        /// </summary>
        /// <param name="origin">The starting position.</param>
        /// <param name="destination">The destination position.</param>
        /// <returns>A <see cref="Distance"/> object that represents the distance calculated.</returns>
        Distance Calculate(Coordinate origin, Coordinate destination);
    }
}
