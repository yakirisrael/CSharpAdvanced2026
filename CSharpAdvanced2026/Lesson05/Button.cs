namespace Lesson05;

public class Button
{
    public delegate void ButtonDelegate(int id);

    private event ButtonDelegate clicked;

    private int id;

    public Button(int id)
    {
        this.id = id;
    }

    public void Subscribe(ButtonDelegate method)
    {
        clicked += method;
    }
    public void Unsubscribe(ButtonDelegate method)
    {
        clicked -= method;
    }

    public void Click()
    {
        clicked?.Invoke(id);
    }
}