using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInvisible : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false; //gör objektet osynligt utanför editorn
    }

    // Update is called once per frame
    void Update()
    {

    }
}
