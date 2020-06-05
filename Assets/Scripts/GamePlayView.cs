using System;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayView : View
{
    [Header("Heads-Up Display")]
    
    [SerializeField] private Text _scoreLabel;

    public void Setup(Action showGameOver)
    {
        GameManager.Instance.SubscribeScore(SetCurrentScore);
        GameManager.Instance.SubscribeGameOver(showGameOver);
        
        GameManager.Instance.Setup();
    }

    private void SetCurrentScore(int score)
    {
        _scoreLabel.text = $"Score: {score}";
    }
}