using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour {

    [Range(0, 20f)]
    public float movespeed;
    public float jumpHeight;


    public GroundCheck groundCheck;

    private Rigidbody2D rbody;

	// Use this for initialization
	void Start ()
    {
        rbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {

        rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * movespeed, rbody.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (groundCheck.touches > 0) // om touches är positiv så kan man inte hoppa alltså när man är i luften
            {
            rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight); //ändrar players y med jumpheight
            }

        }
      
    }
}
