namespace ConsoleApp1.Domains;

public class Triangle : IShape
{
    public Triangle()
    {
        Parameters = new List<double>(NumOfParameters);
    }

    public double CalculateArea()
    {
        var semiPerimeter = (Parameters[0] + Parameters[1] + Parameters[2]) / 2;
        var area = Math.Sqrt(semiPerimeter * (semiPerimeter - Parameters[0]) * (semiPerimeter - Parameters[1]) *
                             (semiPerimeter - Parameters[2]));
        return area;
    }

    public string Name => "Triangle";

    public string ResultOutput
    {
        get
        {
            var area = CalculateArea();
            return
                $"The area of the Triangle with sides of {Parameters[0]} + {Parameters[1]} + {Parameters[2]} is {area}";
        }
    }

    public int NumOfParameters => 3;

    public List<double> Parameters { get; }
}