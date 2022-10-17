namespace ConsoleApp1.Domains;

public interface IShape
{
    public string Name { get; }
    public string ResultOutput { get; }

    public int NumOfParameters { get; }

    public List<double> Parameters { get; }
    public double CalculateArea();
}