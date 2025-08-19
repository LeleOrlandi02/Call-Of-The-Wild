using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Attack : MonoBehaviour
{
    public Animator anim;

    public float cooldown = 2;
    public float timer;

    public void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
        }
    }

    public void Attack()
    {
        if(timer <= 0)
        {
            anim.SetBool("isAttacking", true);
            timer = cooldown;
        }
    }

    public void FinishAttaccking()
    {
        anim.SetBool("isAttacking", false);
    }
}
