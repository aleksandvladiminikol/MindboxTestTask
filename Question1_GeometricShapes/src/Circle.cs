using GeometricShapes.Abstractions;
using GeometricShapes.Utils;

namespace GeometricShapes;

public class Circle : Shapes
{
    public double R { get; }
    public Circle(double r)
    {
        R = r;
        ShapeValidation();
    }

    public override double CalculateArea()
    {
        return AreaCalculatingFormulas.CalculateArea(R);
    }

    protected sealed override void ShapeValidation()
    {
        if (R <= 0)
        {
            throw new ArgumentException("Circle radius should be positive!");
        }
    }
}