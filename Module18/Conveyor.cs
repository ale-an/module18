namespace Module18;

/// <summary>
/// Абстрактный класс строителя
/// </summary>
public abstract class Conveyor
{
    protected Product _product;
      
    public Product Product
    {
        get { return _product; }
    }
    // Методы для постройки составных частей
 
    public abstract void BuildFrame();
    public abstract void BuildEngine();
    public abstract void BuildWheels();
    public abstract void BuildDoors();
}