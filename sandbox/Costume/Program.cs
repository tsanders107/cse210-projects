namespace Costume;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, costume World!");
        List<Costume> myCostumes = new List<Costume>(); // newer version of C# is just List<Costume> myCostumes = []
        Costume detective = new Costume();
        detective._headwear = "Fedora";
        detective._upperGarment = "Trench Coat";
        detective._lowerGarment = "Slacks";
        detective._footwear = "Dress Shoes";
        detective._accessory = "Magnifying Glass";
        myCostumes.Add(detective);

        Costume snorkeler = new Costume();
        snorkeler._headwear = "Goggles";
        snorkeler._upperGarment = "Wetsuit";
        snorkeler._lowerGarment = "Wetsuit";
        snorkeler._footwear = "Flippers";
        snorkeler._accessory = "Snorkel";
        myCostumes.Add(snorkeler);

        foreach (Costume c in myCostumes)
        {
            c.Output();
        }

        string filename = "costumes.csv";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Costume c in myCostumes)
            {
                outputFile.WriteLine($"{c._headwear},{c._upperGarment},{c._lowerGarment},{c._footwear},{c._accessory}");
            }
        }

    }
}
