namespace Module18;

public abstract class BaseClass
{
    protected readonly int Id;

    protected BaseClass(int id)
    {
        Id = id;
    }

    public void GetId()
    {
        Console.WriteLine($"Создан объект с Id {Id}");
    }

    public abstract BaseClass Clone();
}