using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public GameObject GameLogicRoot;

    public GameObject StartGamePage;
    public GameObject GameOverPage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartGame() 
    {
        GameLogicRoot.SetActive(true);
        StartGamePage.SetActive(false);
    }

    public void GameOverScreen() 
    {
        GameOverPage.SetActive(true);
    }

    public void RestartGame() 
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

}
