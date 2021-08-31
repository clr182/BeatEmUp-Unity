using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillaController : MonoBehaviour
{

    public KillaAnimations killaAnimations;
    public float walkMovementSpeed;
    public float attackMovementSpeed;
    public float xMin, xMax, zMin, zMax;

    private float movementSpeed;
    [SerializeField] private Rigidbody rb;


    public bool facingRight = true;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        killaAnimations = GetComponent<KillaAnimations>();
    }

    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = walkMovementSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        inputControl();
    }


    private void inputControl()
    {
        float moveHoriz = Input.GetAxis("Horizontal");
        float moveVert = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(-moveHoriz, 0.0f, -moveVert);

        rb.velocity = movement * movementSpeed;
        rb.position = new Vector3(
            Mathf.Clamp(rb.position.x, xMin, xMax),
            transform.position.y,
            Mathf.Clamp(rb.position.z, zMin, zMax));

        if (moveHoriz > 0 && !facingRight)
        {
            Flip();
        }
        else if (moveHoriz < 0 && facingRight)
        {
            Flip();
        }

        killaAnimations.animatorSetSpeed(rb.velocity.sqrMagnitude);
    }


    public void Flip()
    {
        facingRight = !facingRight;

        transform.Rotate(0, 180, 0);
        
    }
}
