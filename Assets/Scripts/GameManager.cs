using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    void Start()
    {
        InitializeGame();
    }
    
    void InitializeGame()
    {
        // Add game initialization logic here
        Debug.Log("Game Initialized");
        // Other setup code...
    }
    
    public void StartGame()
    {
        // Logic to start the game
        Debug.Log("Game Started");
        // Other game start code...
    }
    
    public void EndGame()
    {
        // Logic to end the game
        Debug.Log("Game Ended");
        // Other game end code...
    }
}