using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{

    public float moveSpeedSlime = 2f;
    public bool isLeft = true;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            if (isLeft == true)
            {
                isLeft = !isLeft;
                transform.Rotate(0, 180, 0);
            }
            else
            {
                isLeft = !isLeft;
                transform.Rotate(0, 180, 0);
            }


        }
    }

    private Rigidbody2D rbody;
    // Use this for initialization
    void Start()
    {
        //Move(false);
    }

    private void Update()
    {
        rbody = GetComponent<Rigidbody2D>();
        if (isLeft == true)
        {
            rbody.velocity = new Vector2(-moveSpeedSlime, rbody.velocity.y);
        }
        else
        {
            rbody.velocity = new Vector2(moveSpeedSlime, rbody.velocity.y);
        }
    }

    //void Move(bool flip)
    //{
    //    if(flip == true)
    //    {
    //        isLeft = !isLeft;
    //    }
    //    isLeft = !isLeft;
    //}
}
