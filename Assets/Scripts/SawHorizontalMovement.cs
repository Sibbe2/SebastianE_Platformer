using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawHorizontalMovement : MonoBehaviour {
    public float moveSpeedSaw = 10f;
    public bool isLeft = true;


    private void OnTriggerEnter2D(Collider2D collision) //när objectet nuddar Border objekten så ändras isLeft så att objektets sprite byter håll 
    {
        if (collision.tag == "Border")
        {
            if (isLeft == true)
            {
                isLeft = false;
                transform.Rotate(0, 180, 0);
            }
            else
            {
                isLeft = true;
                transform.Rotate(0, 180, 0);
            }


        }
    }

    private Rigidbody2D rbody;
    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (isLeft == true)
        {
            rbody.velocity = new Vector2(-moveSpeedSaw, rbody.velocity.y); //byter håll på saw

        }
        else
        {
            rbody.velocity = new Vector2(moveSpeedSaw, rbody.velocity.y); //byter håll på saw

        }
    }

}
