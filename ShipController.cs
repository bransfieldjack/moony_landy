using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour     // Monobehaviours can be attached to game objects. 
{
    public Rigidbody2D rb;  // A reference to the 'rigid body' of the spaceship. 
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool onGround;

    #region MonoBehaviour API

    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float yAxis = Input.GetAxis("Vertical");
        
        rb.velocity = new Vector2(3, rb.velocity.y);
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        if (Input.GetMouseButtonDown(0) && onGround){   // Checks for input of left mouse click.
            rb.velocity = new Vector2(rb.velocity.x, 1);    // If condition is confirmed true, moves forward along the x-axis and permits the jump functionality. 
        }

    }

    #endregion

    #region Maneuvering API     // A region is an area in VS Code where you can specify/organise code.

    #endregion
}
