using UnityEngine;

public class MainMenuViewController : ViewController<MainMenuView>
{
    private ViewControllerFactory _factory;
    
    public MainMenuViewController(MainMenuView view, ViewControllerFactory factory) : base(view)
    {
        _factory = factory;
    }

    public void Setup()
    {
        View.Setup(Application.productName);
        
        View.AddButton("Jogar", StartGame);
        View.AddButton("Configurações", ShowSettingsMenu);
        
#if UNITY_STANDALONE
        View.AddButton("Sair", ExitGame);
#endif
    }

    private void StartGame()
    {
        Debug.Log("StartGame");
    }

    private void ShowSettingsMenu()
    {
        var viewController = _factory.CreateSettingsMenuViewController();
        viewController.Setup(() => {
            viewController.Dismiss();
        });
        
        viewController.View.transform.SetParent(View.transform, false);
    }

    private void ExitGame()
    {
        Debug.Log("ExitGame");
    }
}