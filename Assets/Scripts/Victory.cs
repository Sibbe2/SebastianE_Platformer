using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    public string nextLevel = "Level 2"; //loadar nästa level genom variabeln nextLevel

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(nextLevel); //laddar in nästa level
        }
    }
}
