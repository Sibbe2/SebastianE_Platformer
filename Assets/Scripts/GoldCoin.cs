using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldCoin : MonoBehaviour
{
    //Goldcoins fungerar inte
    public int goldScore = 5;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //skapa en temporär variabel "controller" och sätt den till resultatet av sökningen efter objektet med taggen "GameController"
            GameObject controller = GameObject.FindWithTag("GameController");
            if (controller != null)
            {
                //skapa en temporär variabel "tracker" och sätt den till resultatet av sökningen efter komponenten "ScoreTracker"
                ScoreTracker tracker = controller.GetComponent<ScoreTracker>();
                if (tracker != null)
                {
                    tracker.totalScore += goldScore;
                }
                else
                {
                    Debug.LogError("Score Tracker saknas på GameController");
                }
            }
            else
            {
                Debug.LogError("GameController finns inte");
            }

            Destroy(gameObject);

        }
    }
}
