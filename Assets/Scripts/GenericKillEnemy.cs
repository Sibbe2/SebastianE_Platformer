using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericKillEnemy : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(transform.parent.gameObject); //förstör collidern vid toppen av fiende objektet och dens parent när denna collidern nuddar "Player"
        }
    }
}
