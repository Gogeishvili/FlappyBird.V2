using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOver;
    void Start()
    {
        gameOver.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    public void GameOver()
    {
        gameOver.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}
