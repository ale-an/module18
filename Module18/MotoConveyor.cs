namespace Module18;

public class MotoConveyor : Conveyor
{
    public MotoConveyor()
    {
        _product = new Product("Мотоцикл");
    }

    public override void BuildFrame()
    {
        Product["frame"] = "Рама мотоцикла";
    }

    public override void BuildEngine()
    {
        Product["engine"] = "70 л.с.";
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