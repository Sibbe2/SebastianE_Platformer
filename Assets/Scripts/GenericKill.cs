using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericKill : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(transform.parent.gameObject); //förstör objektet och dens children
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
