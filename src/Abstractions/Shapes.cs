using System;
namespace GeometricShapes.Abstractions
{
    public abstract class Shapes
    {
        public abstract double CalculateArea();
        protected abstract void ShapeValidation();
    }
}