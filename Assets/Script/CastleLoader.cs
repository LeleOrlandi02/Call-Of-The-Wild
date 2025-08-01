using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CastleLoader : MonoBehaviour
{


    public string SceneToLoad;
    public Animator fadeAnim;
    public float fadeTime = .5f;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            fadeAnim.Play("FadeToBlack");
            StartCoroutine(DelayFade());

        }
    }

    IEnumerator DelayFade()
    {
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene(SceneToLoad);
    }
}
