using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public enum GameStates 
    {
        Ready,
        GameStarted,
        RoundStarted,
        QBertDied,
        LevelComplete,
        GameOver

    }

    private GameStates _gameState;
    public GameStates GameState 
    {
        get => _gameState;

        set 
        {
            _gameState = value;
            GameStateChanged.Invoke();
        }
    }

    public bool IsPLaying => GameState == GameStates.RoundStarted;
    int _lives;

    public int Lives 
    {
        get => _lives;

        private set 
        {
            _lives = value;
            LivesChanged.Invoke();
        }
    }

    public UnityEvent LivesChanged = new UnityEvent();
    public UnityEvent GameStateChanged = new UnityEvent();

    Transform _transform;
    BoardManager _boardManager;

    private void Awake()
    {
        if(Instance != null && this != Instance) 
        {
            Destroy(gameObject);
            return;

        }

        Instance = this;
        _transform = transform;
        _boardManager = GetComponent<BoardManager>();
    }

}
