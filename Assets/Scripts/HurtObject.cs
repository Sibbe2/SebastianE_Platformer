using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HurtObject : MonoBehaviour
{
    public int life = 2;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player") //om denna collidern vid sidan av enemyn nuddar "Player" så restartas nuvarande level
        {
            life -= 1;

            if (life <= 0)
            {
                Scene active = SceneManager.GetActiveScene(); //väljer den nuvarande scenen och laddar in den när objektet kolliderar ned "Player" tag
                SceneManager.LoadScene(active.name);

            }
        }
    }
}
