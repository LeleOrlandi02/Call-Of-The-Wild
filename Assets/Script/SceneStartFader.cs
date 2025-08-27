using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStartFader : MonoBehaviour
{
    public static SceneStartFader Instance;

    public Animator fadeAnim;
    public float fadeTime = 2;
    public float extraBlackTime = 0.5f;

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void DoFadeAndLoadScene(string sceneToLoad, Vector2 newPlayerPosition, int newSortingOrder)
    {
        StartCoroutine(FadeRoutine(sceneToLoad, newPlayerPosition, newSortingOrder));
    }

    private IEnumerator FadeRoutine(string sceneToLoad, Vector2 newPlayerPosition, int newSortingOrder)
    {
        // 1. Avvia il fade to black
        fadeAnim.Play("FadeToBlack");

        // 2. Attendi la fine dell'animazione di fade out
        yield return new WaitForSeconds(fadeTime);

        // 3. Carica la nuova scena
        SceneManager.LoadScene(sceneToLoad);

        // 4. Aspetta un frame per permettere alla nuova scena di caricarsi completamente
        yield return null;

        // 5. Trova il player nella nuova scena
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        if (playerObject != null)
        {
            // Sposta il player e aggiorna il suo sorting order
            playerObject.transform.position = newPlayerPosition;
            SpriteRenderer sr = playerObject.GetComponent<SpriteRenderer>();
            if (sr != null)
            {
                sr.sortingOrder = newSortingOrder;
            }
        }

        // 6. ASPETTA QUI PER DARE TEMPO ALLA TELECAMERA DI SISTEMARSI
        // Questo è il tempo di nero aggiuntivo che hai chiesto
        yield return new WaitForSeconds(extraBlackTime);

        // 7. Avvia il fade from black
        fadeAnim.Play("FadeFromBlack");
    }
}
