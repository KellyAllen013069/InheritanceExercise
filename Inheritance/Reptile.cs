namespace Inheritance;

public class Reptile : Animal
{
    public double Length { get; set; }
    public bool IsVenomous { get; set; }
    public string Habitat { get; set; }
    public string ScaleType { get; set; }

    public string DisplayReptileDetails()
    {
        return DisplayAnimalDetails() + "\n" +
               $"Length: {Length} meters\n" +
               $"Venomous: {(IsVenomous ? "Yes" : "No")}\n" +
               $"Habitat: {Habitat}\n" +
               $"Scale Type: {ScaleType}\n" +
               "========================";
    }
}