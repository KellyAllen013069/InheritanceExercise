namespace Inheritance;

public class Bird : Animal
{
    // Create a class Bird
    // give this class 4 members that are specific to Bird
    // Set this class to inherit from your Animal Class
    public double WingSpan { get; set; }
    public bool CanFly { get; set; }
    public string FeatherColor { get; set; }
    public string BeakType { get; set; }

    public string DisplayBirdDetails()
    {
        return DisplayAnimalDetails() + "\n" +
               $"Wing Span: {WingSpan} meters\n" +
               $"Can Fly: {(CanFly ? "Yes" : "No")}\n" +
               $"Feather Color: {FeatherColor}\n" +
               $"Beak Type: {BeakType}\n" +
               "========================";
    }
}