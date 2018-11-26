using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HurtObject : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Scene active = SceneManager.GetActiveScene(); //väljer den nuvarande scenen och laddar in den när objektet kolliderar ned "Player" tag
            SceneManager.LoadScene(active.name);

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            SceneManager.GetActiveScene().IsValid();
        }
    }
}
