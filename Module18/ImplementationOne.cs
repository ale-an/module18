namespace Module18;

public class ImplementationOne : BaseClass
{
    public ImplementationOne(int i) : base(i)
    {
    }

    public override BaseClass Clone()
    {
        return new ImplementationOne(Id);
    }
}