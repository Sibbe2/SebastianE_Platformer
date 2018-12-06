using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{

    public float moveSpeedSlime = 2f;
    public bool isLeft = true;
    private Rigidbody2D rbody;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border") //när objectet nuddar Border objekten så ändras isLeft så att objektets sprite byter håll 
        {
            if (isLeft == true)
            {
                isLeft = !isLeft; //ändrar isLeft till motsattsen när den nuddar något object med tagen "Border" roterar även slimen
                transform.Rotate(0, 180, 0);
            }
            else
            {
                isLeft = !isLeft; //ändrar isLeft till motsattsen när den nuddar något object med tagen "Border" roterar även slimen
                transform.Rotate(0, 180, 0);
            }


        }
    }

    private void Update()
    {
        rbody = GetComponent<Rigidbody2D>();
        if (isLeft == true)
        {
            rbody.velocity = new Vector2(-moveSpeedSlime, rbody.velocity.y); //byter håll på slimen
        }
        else
        {
            rbody.velocity = new Vector2(moveSpeedSlime, rbody.velocity.y); //byter håll på slimen
        }
    }
}
