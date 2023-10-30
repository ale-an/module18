namespace Module18;

public class ImplementationTwo : BaseClass
{
    public ImplementationTwo(int i) : base(i)
    {
    }

    public override BaseClass Clone()
    {
        return new ImplementationTwo(Id);
    }
}