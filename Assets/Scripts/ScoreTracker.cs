using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // <-- namespace, så att man kan använda 
//using UnityEngine.UI

public class ScoreTracker : MonoBehaviour
{
    public TextMeshProUGUI scoreText; //texten i det högra hörnet av skärmen
    public int totalScore; //all score som samlats under denna scenen

    private void Update()
    {
        scoreText.text = string.Format("Score: {0}", totalScore); //printar totalScore ifrån goldScore och score på skärmen
    }

}

