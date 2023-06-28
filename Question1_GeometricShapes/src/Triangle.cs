using GeometricShapes.Abstractions;
using GeometricShapes.Utils;

namespace GeometricShapes;

public class Triangle : Shape
{
    public double A { get; }
    public double B { get; }
    public double C { get; }
    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
        ShapeValidation();
    }
    public sealed override void ShapeValidation()
    {
        if (!(A > 0 && B > 0 && C > 0))
            throw new ArgumentException("Triangle arguments should be positive");
        if (!(A + B > C && B + C > A && A + C > B))
            throw new ArgumentException($"Incompatible side lengths: {A}, {B}, {C}");
    }
    public override double CalculateArea()
    {
        return AreaCalculatingFormulas.CalculateArea(A, B, C);
    }
    public bool IsEquilateralTriangle() => (A == B && B == C);
}