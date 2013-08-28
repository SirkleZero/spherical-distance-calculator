using System;

namespace System
{
    public static class MathExtensions
    {
        /// <summary>
        /// Convert a double that represents an angle to its equivalent in Radians.
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static double ToRadians(this double angle)
        {
            // 1 radian = 180 / π degrees
            return (Math.PI / 180) * angle;
        }

        /// <summary>
        /// Convert a double that represents a Radian to its equivalent angle.
        /// </summary>
        /// <param name="radians"></param>
        /// <returns></returns>
        public static double ToDegrees(double radians)
        {
            // 1 degree = π / 180 radians
            return (Math.PI / 180) * radians;
        }
    }
}
