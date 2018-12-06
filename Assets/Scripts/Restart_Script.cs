using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart_Script : MonoBehaviour
{ 
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("SampleScene"); //finns på leveln "Platformer_Restart" som loadar första leven "SampleScene"
        }
    }
}
