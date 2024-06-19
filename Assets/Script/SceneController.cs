using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void Gameplay()
    {
        SceneManager.LoadScene("Gameplay");
        Debug.Log("Masuk Ke Scene Gameplay");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Keluar dari Aplikasi");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
