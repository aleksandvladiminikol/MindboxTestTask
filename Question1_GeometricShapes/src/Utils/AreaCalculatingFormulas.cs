namespace GeometricShapes.Utils
{
    /// <summary>
    /// This class was created to accumulate formulas for calculating the area of geometric shapes.
    /// The class contains one method that has different overloads, with different numbers of input parameters.
    /// Each overload corresponds to a formula for calculating the area of a shape by the number of its significant parameters.
    /// For a triangle these are three sides, for a circle only the radius,
    /// similarly for any polygon you can create a similar universal formula.
    /// </summary>
    public static class AreaCalculatingFormulas
    {
        /// <summary>
        /// Overloaded method for calculating circle area
        /// </summary>
        /// <param name="r">
        /// Circle radius
        /// </param>
        /// <returns>Calculated circle area
        /// </returns>
        public static double CalculateArea(double r) =>
            Math.PI * Math.Pow(r, 2);
        
        /// <summary>
        /// Overloaded method for calculating triangle area
        /// </summary>
        /// <param name="a">Triangle side №1</param>
        /// <param name="b">Triangle side №2</param>
        /// <param name="c">Triangle side №3</param>
        /// <returns></returns>
        public static double CalculateArea(double a, double b, double c)
        {
            var p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}