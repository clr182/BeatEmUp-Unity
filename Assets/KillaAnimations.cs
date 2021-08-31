using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillaAnimations : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator animator;
    public AnimatorStateInfo currentStateInfo;

    static int currentState;
    static int idleState = Animator.StringToHash("Base Layer.Idle");
    static int walkState = Animator.StringToHash("Base Layer.Walk");
    static int attack1State = Animator.StringToHash("Base Layer.Attack1");
    static int attack2State = Animator.StringToHash("Base Layer.Attack2");
    static int attack3State = Animator.StringToHash("Base Layer.Attack3");
    static int jumpState = Animator.StringToHash("Base Layer.Jump");
    static int hurtState = Animator.StringToHash("Base Layer.Hurt");


    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        currentStateInfo = animator.GetCurrentAnimatorStateInfo(0);
        currentState = currentStateInfo.fullPathHash;
        CheckCurrentState();
    }

    public void animatorSetSpeed(float vel)
    {
        animator.SetFloat("Speed", vel);
    }


    public int GetCurrentState()
    {
        return currentState;
    }

    public void SetCurrentState(int newCurrentState)
    {
        currentState = newCurrentState;
    }


    private void CheckCurrentState()
    {
        if(currentState == idleState)
        {
            Debug.Log("Idle State");
        }
        if(currentState == walkState)
        {
            Debug.Log("Walk State");
        }
        if (currentState == attack1State)
        {
            Debug.Log("Attack 1 State");
        }
        if (currentState == attack2State)
        {
            Debug.Log("Attack 2 State");
        }
        if (currentState == attack3State)
        {
            Debug.Log("Attack 3 State");
        }
        if (currentState == jumpState)
        {
            Debug.Log("Jump State");
        }
        if(currentState == hurtState)
        {

        }
    }
}
