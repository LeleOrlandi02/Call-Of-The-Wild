using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class NPC_patrol : MonoBehaviour
{
    public Vector2[] patrolPoints;

    private int currentPatrolIndex;
    private Vector2 target;

    public float pauseDuration = 1.5f;

    private bool isPaused; 
    public float speed = 2;

    private Rigidbody2D rb;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
        currentPatrolIndex = 0;
        target = transform.TransformPoint(patrolPoints[currentPatrolIndex]);
        StartCoroutine(SetPatrolPoint());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isPaused)
        {
            rb.velocity = Vector2.zero;
            return;
        }

        Vector2 direction = ((Vector3) target - transform.position).normalized;
            if (direction.x < 0 && transform.localScale.x > 0 || direction.x > 0 && transform.localScale.x < 0)
                transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
        
        rb.velocity = direction * speed;

        if (Vector2.Distance(transform.position, target) < .1f)
            StartCoroutine(SetPatrolPoint());
    }

    IEnumerator SetPatrolPoint()
    {
        isPaused = true;
        anim.Play("Idle");
        yield return new WaitForSeconds(pauseDuration);
        currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;
        target = patrolPoints[currentPatrolIndex];
        isPaused = false;
        anim.Play("Walk");
    }
}
    
