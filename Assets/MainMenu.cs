using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int IndexSceneToLoad;
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(IndexSceneToLoad);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
