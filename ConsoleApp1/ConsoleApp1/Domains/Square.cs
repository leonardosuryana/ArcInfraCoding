namespace ConsoleApp1.Domains;

public class Square : IShape
{
    public Square()
    {
        Parameters = new List<double>(NumOfParameters);
    }

    public double CalculateArea()
    {
        return Math.Pow(Parameters[0], 2);
    }

    public string ResultOutput
    {
        get
        {
            var area = CalculateArea();
            return $"The area of the Square with sides of {Parameters[0]} is {area}";
        }
    }

    public string Name => "Square";

    public int NumOfParameters => 1;

    public List<double> Parameters { get; }
}