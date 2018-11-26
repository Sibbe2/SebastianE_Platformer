using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueKey : MonoBehaviour
{

    public bool haveKey = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject[] holes = GameObject.FindGameObjectsWithTag("Keyhole"); //hittar alla gameobjects med Keyhole taget och förstör dem 
            foreach (GameObject item in holes)
            {
                Destroy(item);
            }
            Destroy(gameObject);
            haveKey = true;
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
}
