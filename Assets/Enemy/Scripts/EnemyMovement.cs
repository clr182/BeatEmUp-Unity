using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    private Vector3 dir = Vector3.forward;
    public Animator Controller;



    //Your Update function
    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);

        if (transform.position.x <= -4)
        {
            dir = Vector3.forward;
            Controller.SetBool("Walking", true);
        }
        else if (transform.position.x >= 4)
        {
            dir = -Vector3.forward;
            Controller.SetBool("Walking", true);
        }
    }
}
