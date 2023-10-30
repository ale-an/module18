namespace Module18;

/// <summary>
/// Автомобильный завод
/// </summary>
class CarPlant
{
    /// <summary>
    /// Запуск процесса постройки
    /// </summary>
    public void Construct(Conveyor conveyor)
    {
        conveyor.BuildFrame();
        conveyor.BuildEngine();
        conveyor.BuildWheels();
        conveyor.BuildDoors();
    }
}