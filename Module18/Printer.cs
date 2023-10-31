namespace Module18;

public class Printer
{
    /// <summary>
    ///  Запуск принтера
    /// </summary>
    public void Start(int size, string material)
    {
        var sizeString = "large";
        var sizeNumber = "XL";

        switch (size)
        {
            case < 10:
                sizeString = "small";
                sizeNumber = "M";
                break;
            case < 90:
                sizeString = "medium";
                sizeNumber = "L";
                break;
        }
        Console.WriteLine($"Size {sizeNumber}");
        Console.WriteLine($"Awesome Print {sizeString} on {material}");
    }
}