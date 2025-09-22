using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Knight : MonoBehaviour
{
    public enum NPCState { Default, Idle, Talk}
    public NPCState currentState = NPCState.Idle;
    private NPCState defaultState;
    public NPC_talk talk;

    // Start is called before the first frame update
    void Start()
    {
        defaultState = currentState;
        SwitchState(currentState);
    }

    public void SwitchState(NPCState newState)
    {
        currentState = newState;

        talk.enabled = newState == NPCState.Talk;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            SwitchState(NPCState.Talk);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
            SwitchState(defaultState);  
    }
}
