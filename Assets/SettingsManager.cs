using UnityEngine;
using UnityEngine.Audio; // Necessario per l'Audio Mixer
using UnityEngine.UI;    // Necessario per lo Slider

public class SettingsManager : MonoBehaviour
{
    public AudioMixer mainMixer;
    public Slider volumeSlider;

    private void Start()
    {
        // Carica il volume salvato all'avvio del gioco
        // Se non c'è un valore salvato, usa 1 (massimo) come default
        float savedVolume = PlayerPrefs.GetFloat("MasterVolume", 1f);

        // Imposta il volume nel mixer
        SetVolume(savedVolume);

        // Aggiorna la posizione dello slider
        volumeSlider.value = savedVolume;
    }

    // Questa funzione pubblica verrà chiamata dallo slider
    public void SetVolume(float sliderValue)
    {
        // La conversione da lineare (0-1) a decibel (logaritmica) è necessaria
        // perché i mixer audio funzionano in decibel.
        mainMixer.SetFloat("MasterVolume", Mathf.Log10(sliderValue) * 20);

        // Salva il valore dello slider per le prossime sessioni di gioco
        PlayerPrefs.SetFloat("MasterVolume", sliderValue);
    }
}