using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CounterManager : MonoBehaviour
{
    public static CounterManager Instance;

    public int enemiesRemaining;
    public TMP_Text enemiesText;


    private void Start()
    {
        enemiesText.text = ": " + enemiesRemaining + " / 8";
    }

    void Awake()
    {
        // Make sure there’s only one GameManager
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // persists between scenes
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void UpdateUI()
    {
        if (enemiesText != null)
            enemiesText.text = ": " + enemiesRemaining + " / 8";
    }

    public void SetEnemies(int count)
    {
        enemiesRemaining = count;
        UpdateUI();
    }

    public void EnemyKilled()
    {
        enemiesRemaining--;
        UpdateUI();
    }
}
