namespace Module18;

public class ScooterConveyor : Conveyor
{
    public ScooterConveyor()
    {
        _product = new Product("Скутер");
    }

    public override void BuildFrame()
    {
        Product["frame"] = "Рама скутера";
    }

    public override void BuildEngine()
    {
        Product["engine"] = "25 л.с.";
    }

    public override void BuildWheels()
    {
        Product["wheels"] = "2";
    }

    public override void BuildDoors()
    {
        Product["doors"] = "0";
    }
}