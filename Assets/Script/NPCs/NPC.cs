using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public enum NPCState { Default, Idle, Patrol, Talk}
    public NPCState currentState = NPCState.Patrol;
    private NPCState defaultState;

    public NPC_patrol patrol;
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

        patrol.enabled = newState == NPCState.Patrol;
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
