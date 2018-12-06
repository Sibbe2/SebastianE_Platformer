using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HurtObject : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") //om denna collidern vid sidan av enemyn nuddar "Player" så restartas nuvarande level
        {
            Scene active = SceneManager.GetActiveScene(); //restartar nivån som spelaren är på
            SceneManager.LoadScene(active.name);
        }
    }
}
