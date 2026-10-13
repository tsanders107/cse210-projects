namespace Costume;

public class Costume
{
    // attributes
    public string _headwear;
    public string _upperGarment;
    public string _lowerGarment;
    public string _footwear;
    public string _accessory;

    // behavior
    public void Output()
    {
        Console.WriteLine("Costume specification:");
        Console.WriteLine($"Head: {_headwear}");
        Console.WriteLine($"Topt: {_upperGarment}");
        Console.WriteLine($"Bottom: {_lowerGarment}");
        Console.WriteLine($"Feet: {_footwear}");
        Console.WriteLine($"Accessory: {_accessory}");
    }
}