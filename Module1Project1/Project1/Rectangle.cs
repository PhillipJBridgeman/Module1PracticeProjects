/*
 * FileName: Project1.cs
 * Author: Phillip Bridgeman
 * Date Created: 2023-05-04
 * Last Modified: 2023-05-04
 * Version: 1.0.0
 * Description: This class represents a rectangle and method performing calculations.
 */

using System;

namespace Project1
{
    /// <summary>
    /// Represents a rectangle with height and width.
    /// </summary>
    public class Rectangle
    {
        private decimal height;
        private decimal width;

        /// <summary>
        /// Initializes a instance of Rectangle with no specified width or height.
        /// </summary>
        public Rectangle() { }

        /// <summary>
        /// Initializes a instance of Rectangle with specified width and height
        /// </summary>
        /// <param name="height">The height of the rectangle.</param>
        /// <param name="width">The width of the rectangle.</param>
        public Rectangle(decimal width, decimal height)
        {
            this.height = height;
            this.width = width;
        }

        /// <summary>
        /// Gets the height of the rectangle.
        /// </summary>
        /// <returns>Returns the decimal value of the height of the rectangle.</returns>
        public decimal GetHeight()
        {
            return this.height;
        }

        /// <summary>
        /// Gets the width of the rectangle.
        /// </summary>
        /// <returns>Return the decimal value of the width of the rectangle.</returns>
        public decimal GetWidth()
        {
            return this.width; 
        }

        /// <summary>
        /// Gets the calculated area of the rectangle.
        /// </summary>
        /// <returns>Returns the decimal value of the area of the rectangle.</returns>
        public decimal GetArea()
        {
            return this.height * this.width;
        }

        /// <summary>
        /// Gets the calculated perimeter of the rectangle.
        /// </summary>
        /// <returns>Return the decimal value of the perimeter of the rectangle.</returns>
        public decimal GetPerimeter()
        {
            return ((2 * this.width) + (2 * this.height));
        }

        /// <summary>
        /// String representation of the rectangle with width, height, area, and perimeter.
        /// </summary>
        /// <returns>Returns a string representation of the rectangle.</returns>
        public override string ToString()
        {
            return $"W: {width} H: {height} A: {GetArea()} P: {GetPerimeter()}";
        }
    }
}