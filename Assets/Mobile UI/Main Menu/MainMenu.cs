using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [Header("Scena da caricare")]
    public int IndexSceneToLoad;
    [Header("Posizione Iniziale del Giocatore")]
    // Questo campo apparirà nell'Inspector!
    public Vector2 startPosition;
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(IndexSceneToLoad);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
