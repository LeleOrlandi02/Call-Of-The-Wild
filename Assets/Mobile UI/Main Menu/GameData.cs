using UnityEngine;

public static class GameData
{
    // Un "interruttore" per sapere se dobbiamo usare una posizione personalizzata
    public static bool HasCustomStartPosition = false;

    // Una variabile per memorizzare le coordinate X e Y
    public static Vector2 CustomStartPosition;
}