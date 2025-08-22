using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBootstrapper : MonoBehaviour
{
    // Riferimento al tuo prefab del fader
    public GameObject faderPrefab;

    void Awake()
    {
        // Controlla se il fader persistente esiste già
        if (SceneStartFader.Instance == null)
        {
            // Se non esiste, lo crea dalla prefab
            Instantiate(faderPrefab);
        }
    }
}
