using System;
namespace GeometricShapes.Abstractions
{
    public abstract class Shape: IShape
    {
        public abstract double CalculateArea();
        public abstract void ShapeValidation();
    }
}