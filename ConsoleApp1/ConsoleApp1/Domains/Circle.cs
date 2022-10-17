namespace ConsoleApp1.Domains;

public class Circle : IShape
{
    public Circle()
    {
        Parameters = new List<double>(NumOfParameters);
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Parameters[0], 2);
    }


    public string Name => "Circle";

    public string ResultOutput
    {
        get
        {
            var area = CalculateArea();
            return $"The area of the Circle with radius of {Parameters[0]} is {area}";
        }
    }

    public int NumOfParameters => 1;

    public List<double> Parameters { get; }
}