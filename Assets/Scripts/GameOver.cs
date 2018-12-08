﻿using UnityEngine.SceneManagement; 
using UnityEngine;

public class GameOver : MonoBehaviour {

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
