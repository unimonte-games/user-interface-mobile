using UnityEngine;

public class AppDelegate : MonoBehaviour
{
    [SerializeField] private SceneWireframe _wireframe;
    [SerializeField] private AssetLoader _assetLoader;
    
    [Header("Test Only")]
    [SerializeField] private InspectorViewControllerFactory _inspectorFactory;

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        new GameInitializer(_wireframe, _assetLoader).Init();
    }
}
