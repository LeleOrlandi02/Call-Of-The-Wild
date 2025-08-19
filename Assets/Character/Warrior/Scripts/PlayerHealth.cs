using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int currentHealth;
    public int maxHealt;

    public SpriteRenderer playerSr;
    public NewBehaviourScript playerMovement;

    public void ChangeHealth(int amount)
    {
        currentHealth += amount;

        if(currentHealth <= 0)
        {
            playerSr.enabled = false;
            playerMovement.enabled = false;
        }
    }
}
