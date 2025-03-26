using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();  // Prende l'Animator del personaggio
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))  // Cambia "Space" con il tasto che vuoi
        {
            animator.SetTrigger("Attack");  // Attiva l'animazione
        }
    }
}
