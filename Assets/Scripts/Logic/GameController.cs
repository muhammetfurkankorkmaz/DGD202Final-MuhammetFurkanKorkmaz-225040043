using System;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance;
    private PelletSpawner _pelletSpawner;
    private PelletCollector _pelletCollector;
    [SerializeField] private GameObject _gameOverScreen;

    public event Action onGameStart;

    private void Awake()
    {

        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
        _pelletSpawner = GetComponent<PelletSpawner>();
        _pelletCollector = GetComponent<PelletCollector>();
    }

    private void Start()
    {
        StartGame();
    }

    public void StartGame()
    {
        _gameOverScreen.SetActive(false);
        _pelletCollector.ResetCounter();
        _pelletSpawner.SpawnPellets();
        onGameStart?.Invoke();
    }

    public void EndGame()
    {
        _gameOverScreen.SetActive(true);
    }
}
