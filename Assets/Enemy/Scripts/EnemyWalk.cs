using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyWalk : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    EnemySight enemySight;
    public float enemySpeed;
    public float enemyCurrentSpeed;
    public bool facingRight;
    Animator animator;

    private void Awake()
    {
        navMeshAgent = gameObject.GetComponent<NavMeshAgent>();
        enemySight = gameObject.GetComponent<EnemySight>();
        animator = GetComponentInChildren<Animator>();
        navMeshAgent.speed = enemySpeed;
    }

    void Start()
    {
        
    }

    void Update()
    {
        if(enemySight.playerInSight == true)
        {
            navMeshAgent.SetDestination(enemySight.target.transform.position);
            navMeshAgent.updateRotation = false;
            animator.SetBool("Walking", true);

            if(enemySight.targetDistance < .1f)
            {
                animator.SetBool("Walking", false);
            }

            if(enemySight.playerOnRight== true && facingRight)
            {
                Flip();
            }
            else if(enemySight.playerOnRight == false && !facingRight)
            {
                Flip();
            }
        }
    }

    public void Flip()
    {
        facingRight = !facingRight;

        transform.Rotate(0, 180, 0);

    }
}
