using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    void Start()
    {
        // Controlla se il menu ha inviato delle coordinate personalizzate
        if (GameData.HasCustomStartPosition)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            if (player != null)
            {
                // Imposta la posizione del player usando le coordinate memorizzate
                player.transform.position = GameData.CustomStartPosition;
                Debug.Log("Posizione Player impostata dal menu a: " + GameData.CustomStartPosition);
            }

            // FONDAMENTALE: Resettiamo l'interruttore
            GameData.HasCustomStartPosition = false;
        }
    }
}