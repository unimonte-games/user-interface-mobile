using UnityEngine;

public class MainMenuViewController : ViewController<MainMenuView>
{
    private SceneWireframe _wireframe;
    private IViewControllerFactory _factory;
    
    public MainMenuViewController(MainMenuView view, SceneWireframe wireframe, IViewControllerFactory factory) : base(view)
    {
        _wireframe = wireframe;
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
        var viewController = _factory.CreateGamePlayViewController();
        viewController.Setup();
        
        _wireframe.Present(viewController);
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