using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // <-- namespace
//using UnityEngine.UI

public class ScoreTracker : MonoBehaviour
{
    public TextMeshProUGUI scoreText; 
    public int totalScore; //all score som samlats under denna scenen

    private void Update()
    {
        scoreText.text = string.Format("Score: {0}", totalScore); //printar totalScore ifrån goldScore och score på skärmen
    }

}

