using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item")]
public class ItemSO : ScriptableObject
{
    [Header("Item Info")]
    public string itemName;
    [TextArea] public string itemDesc;
    public Sprite icon;

    [Header("Item Stats")]
    public int currentHealth;
    public int maxHealth;
}
