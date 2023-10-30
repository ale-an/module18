namespace Module18;

public class CarConveyor : Conveyor
{
    public CarConveyor()
    {
        _product = new Product("Автомобиль");
    }

    public override void BuildFrame()
    {
        Product["frame"] = "Рама автомобиля";
    }

    public override void BuildEngine()
    {
        Product["engine"] = "150 л.с.";
    }

    public override void BuildWheels()
    {
        Product["wheels"] = "4";
    }

    public override void BuildDoors()
    {
        Product["doors"] = "4";
    }
}