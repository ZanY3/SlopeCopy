using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void LoadGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game");
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
    public void LoadTGCLink()
    {
        Application.OpenURL("https://t.me/zany1y");
    }
    public void LoadYTLink()
    {
        Application.OpenURL("https://www.youtube.com/@zany1y/videos");
    }
}
