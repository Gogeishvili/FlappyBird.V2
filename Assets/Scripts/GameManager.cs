using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverObject;
    void Start()
    {
        GameOverObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        GameOverObject.SetActive(true);
        Time.timeScale = 0;
    }
}
