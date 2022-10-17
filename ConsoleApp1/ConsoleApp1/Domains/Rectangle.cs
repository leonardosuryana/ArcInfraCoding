namespace ConsoleApp1.Domains;

public class Rectangle : IShape
{
    public Rectangle()
    {
        Parameters = new List<double>(NumOfParameters);
    }

    public List<double> Parameters { get; }

    public double CalculateArea()
    {
        return Parameters[0] * Parameters[1];
    }

    public string Name => "Rectangle";

    public string ResultOutput
    {
        get
        {
            var area = CalculateArea();
            return $"The area of the Rectangle with sides of {Parameters[0]} + {Parameters[1]} is {area}";
        }
    }
    public int NumOfParameters => 2;
}