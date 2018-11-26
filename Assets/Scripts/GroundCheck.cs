using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{

    public int touches;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        touches++; //den gör så att om FeetGrounded nuddar marken så blir touches positiv (se PlayerMovement)
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        touches--; //den gör så att om FeetGrounded inte nuddar marken så blir touches negativ
    }
}
