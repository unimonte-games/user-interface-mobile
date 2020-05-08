﻿using UnityEngine;

public class SceneWireframe : MonoBehaviour
{
    [SerializeField] private Transform _holder;

    public void Present<T>(ViewController<T> viewController) where T : View
    {
        Present(viewController.View);
    }
    
    public void Present(View view)
    {
        foreach (Transform child in _holder) {
            Destroy(child.gameObject);
        }
        
        view.transform.SetParent(_holder, false);
    }
}
