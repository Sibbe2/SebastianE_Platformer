using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    public string levelToLoad = "Level 2";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("YAY");
            SceneManager.LoadScene("Level 2"); //laddar in nästa level
        }
    }
}
