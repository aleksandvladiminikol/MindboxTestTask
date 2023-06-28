namespace GeometricShapes.Abstractions;

internal interface IShape
{
    public abstract double CalculateArea();
    protected abstract void ShapeValidation();
}