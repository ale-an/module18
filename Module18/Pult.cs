namespace Module18;

public class Pult
{
    private IAction action;

    public void SetAction(IAction paramAction)
    {
        action = paramAction;
    }

    public void OpenButton()
    {
        action.Run();
    }

    public void CloseButton()
    {
        action.Undo();
    }
}