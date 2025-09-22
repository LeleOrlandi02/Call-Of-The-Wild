using UnityEngine;
using UnityEngine.SceneManagement; // Importante per cambiare scena

public class PauseMenuManager : MonoBehaviour
{
    public GameObject pauseMenuPanel; // Riferimento al pannello del menu
    private bool isPaused = false;

    // Questa funzione verrà chiamata dal pulsante di pausa
    public void TogglePauseMenu()
    {
        isPaused = !isPaused; // Inverte lo stato di pausa

        if (isPaused)
        {
            // Metti in pausa il gioco e apri il menu
            pauseMenuPanel.SetActive(true);
            Time.timeScale = 0f; // Ferma il tempo di gioco
        }
        else
        {
            // Riprendi il gioco e chiudi il menu
            pauseMenuPanel.SetActive(false);
            Time.timeScale = 1f; // Fa ripartire il tempo di gioco
        }
    }

    // Questa funzione verrà chiamata dal pulsante per tornare al menu principale
    public void ReturnToMainMenu()
    {
        // FONDAMENTALE: ripristina il tempo prima di cambiare scena,
        // altrimenti la scena del menu si caricherà in pausa!
        Time.timeScale = 1f;

        // Sostituisci "MainMenu" con il nome esatto della tua scena del menu principale
        SceneManager.LoadScene("MainMenu");
    }
}