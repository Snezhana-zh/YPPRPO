namespace LagrangeInterpolation.Tests;
using Xunit;
public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        List<double> xv = new List<double> { 1, 2, 3 };
        List<double> yv = new List<double> { 1, 4, 9 };
        double xi = 5;
        double interpolatedValue = LagrangeInterpolation.Lagrange(xv, yv, xi);
        Assert.Equal(25.0, interpolatedValue, 0.00000001);
    }
    [Fact]
    public void Test2()
    {
        List<double> xv = new List<double> {};
        List<double> yv = new List<double> {};
        double xi = 0;
        double interpolatedValue = LagrangeInterpolation.Lagrange(xv, yv, xi);
        Assert.Equal(0, interpolatedValue, 0.00000001);
    }
    [Fact]
    public void Test3()
    {
        List<double> xv = new List<double> { 1, 2, 3 };
        List<double> yv = new List<double> { 1, 4};
        double xi = 5;
        Assert.Throws<Exception>(() => LagrangeInterpolation.Lagrange(xv, yv, xi));
    }
    [Fact]
    public void Test4()
    {
        string[] args = { };
        Assert.Throws<ArgumentException>(() => Arguments.FillParams(args));
    }
}
