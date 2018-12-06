using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericKillEnemy : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(transform.parent.gameObject); //finns på collidern på toppen av enemyn som när den triggas förstör sig själv och dens parent
        }
    }
}
