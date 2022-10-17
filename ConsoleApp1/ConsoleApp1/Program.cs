// See https://aka.ms/new-console-template for more information

using System.Reflection;
using ConsoleApp1.Domains;

var shapes = Assembly.GetExecutingAssembly().GetTypes().Where(x => typeof(IShape).IsAssignableFrom(x) && x.IsClass);

foreach (var shapeType in shapes)
{
    var instance = (IShape)Activator.CreateInstance(shapeType);
    Console.WriteLine(instance.Name);
    var counter = 1;
    for (var i = 0; i < instance.NumOfParameters; i++)
    {
        Console.WriteLine($"Please define parameter {counter}:");
        int parameter;

        while (!int.TryParse(Console.ReadLine(), out parameter))
        {
            Console.WriteLine("You have entered an invalid number");
            Console.WriteLine($"Please define parameter {counter}:");
        }

        counter++;
        instance.Parameters.Add(parameter);
    }

    Console.WriteLine(instance.ResultOutput);
}