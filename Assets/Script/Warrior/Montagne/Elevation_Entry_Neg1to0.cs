using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevation_Entry_Neg1to0 : MonoBehaviour
{
    public Collider2D[] mountainColliders;
    public Collider2D[] boundaryolliders;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            foreach (Collider2D mountain in mountainColliders)
            {
                mountain.enabled = false;
            }

            foreach (Collider2D boundary in boundaryolliders)
            {
                boundary.enabled = true;
            }

            collision.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 5;
        }
    }
}
