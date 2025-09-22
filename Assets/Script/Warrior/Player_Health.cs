using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Health : MonoBehaviour
{
    public int currentHealth;
    public int maxHealt;

    public SpriteRenderer playerSr;
    public Player_Movement playerMovement;

    // Evita che la logica di "morte" venga eseguita più volte
    private bool isDead = false;

    public void ChangeHealth(int amount)
    {
        if (isDead) return;

        currentHealth += amount;
        // Assicura che la vita rientri nei limiti validi
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealt);

        if (currentHealth <= 0)
        {
            isDead = true;

            playerSr.enabled = false;
            playerMovement.enabled = false;

            // Metti in pausa il gioco
            Time.timeScale = 0f;
            // Metti in pausa l'audio globale (opzionale)
            AudioListener.pause = true;

            GameManager.Instance.ShowGameOverScreen();
        }
    }
}
