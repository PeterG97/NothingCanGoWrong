namespace GameLogic;

public partial class MainMenu : Node
{
    public void _on_start_pressed()
        => GameManager.Instance.SetLevel(1);

    public void _on_options_pressed()
    {

    }

    public void _on_quit_pressed()
        => GetTree().Quit();
}
