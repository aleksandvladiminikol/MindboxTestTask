using FluentAssertions;
using GeometricShapes;
using Xunit;

namespace GeometricShapesTests;

public class TriangleTests
{
    [Theory]
    [InlineData(3, 4, 5)]
    [InlineData(14.0001, 28, 14)]
    public void Triangle_Should_InitializeInstance_When_PassedValidParameters(double a, double b, double c)
    {
        var circle = new Triangle(a, b, c);
        circle.Should().BeOfType(typeof(Triangle));
    }
    
    [Theory]
    [InlineData(0, 4, 5)]
    [InlineData(1, 4, -5)]
    [InlineData(2, 4, 2)]
    [InlineData(15, 15, 35)]
    public void Triangle_Should_ThrowArgumentException_When_PassedInvalidParameters(double a, double b, double c)
    {
        Action act = () => new Triangle(a, b, c);
        act.Should().Throw<ArgumentException>();
    }

    [Theory]
    [InlineData(5, 4, 3, 6.000)]
    [InlineData(9.5, 23, 14.56, 39.616)]
    [InlineData(34.5, 54.6, 81.5, 710.996)]
    [InlineData(543124.0001, 401230.5, 312468.9999999, 62023449517.144)]
    public void CalculateArea_Should_ProperlyCalculateArea(double a, double b, double c, double expectedArea)
    {
        var triangle = new Triangle(a, b, c);
        double.Round(triangle.CalculateArea(), 3).Should().Be(expectedArea);
    }
    
    [Theory]
    [InlineData(5, 4, 3, false)]
    [InlineData(9.5, 9.5, 14.56, false)]
    [InlineData(9.5, 14.56, 9.5, false)]
    [InlineData(14.56, 9.5, 9.5, false)]
    [InlineData(34.5, 34.5, 34.5, true)]
    [InlineData(401230.5, 401230.5, 401230.5, true)]
    public void IsEquilateralTriangle_Should_IdentifyEquilateralTriangle(double a, double b, double c, bool equilateral)
    {
        var triangle = new Triangle(a, b, c);
        var isEquilateral = triangle.IsEquilateralTriangle();
        isEquilateral.Should().Be(equilateral);
    }
}