using System;

public class SettingsMenuViewController : ViewController<SettingsMenuView>
{
    public SettingsMenuViewController(SettingsMenuView view) : base(view) { }

    public void Setup(Action backCallback)
    {
        View.Setup("Voltar", backCallback);
    }
}
