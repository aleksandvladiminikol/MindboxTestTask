using Xunit;
using FluentAssertions;
using GeometricShapes;

namespace GeometricShapesTests;

public class CircleTests
{
    [Theory]
    [InlineData(0.000001)]
    [InlineData(1)]
    [InlineData(500000.02)]
    public void Circle_Should_InitializeInstance_When_PassedValidRadius(double r)
    {
        var circle = new Circle(r);
        circle.Should().BeOfType(typeof(Circle));
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(-5)]
    public void Circle_Should_ThrowArgumentException_When_PassedNegativeRadius(double radius)
    {
        Action act = () => new Circle(radius);
        act.Should().Throw<ArgumentException>();
    }

    [Theory]
    [InlineData(1, 3.142)]
    [InlineData(5, 78.540)]
    [InlineData(9.2, 265.904)]
    public void CalculateArea_Should_ProperlyCalculateArea(double radius, double area)
    {
        var circle = new Circle(radius);
        double.Round(circle.CalculateArea(), 3).Should().Be(area);
    }
}