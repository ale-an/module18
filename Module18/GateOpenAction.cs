namespace Module18;

public interface IAction
{
    void Run();
    void Undo();
}

public class GateOpenAction : IAction
{
    private Gate _gate;

    public GateOpenAction(Gate gate)
    {
        _gate = gate;
    }

    public void Run()
    {
        _gate.Open();
    }

    public void Undo()
    {
        _gate.Close();
    }
}