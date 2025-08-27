using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CastleLoader : MonoBehaviour
{
    public string SceneToLoad;
    public Vector2 newPlayerPosition;
    public int newSortingOrder = 5;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneStartFader.Instance.DoFadeAndLoadScene(SceneToLoad, newPlayerPosition, newSortingOrder);
        }
    }
}
