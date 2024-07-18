namespace Inheritance;

public class Animal
{
    // give this class 4 members that all Animals have in common
    public string Name { get; set; }
    public int Age { get; set; }
    public string Species { get; set; }
    public double Weight { get; set; }

    protected string DisplayAnimalDetails()
    {
        return $"Name: {Name}, Age: {Age}, Species: {Species}, Weight: {Weight} kg";
    }
}