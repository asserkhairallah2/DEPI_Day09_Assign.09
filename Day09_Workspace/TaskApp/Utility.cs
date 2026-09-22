using System;

namespace TaskApp
{
    #region Utility Class
    public static class Utility
    {
        public static double CalculateRectanglePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
    #endregion
}