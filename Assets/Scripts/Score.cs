using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{


    //textos
    public  Text scoreTextPlayer1;
    public  Text scoreTextPlayer2;

    //scores
    public static int scoreP1;
    public static int scoreP2;

    
    // Start is called before the first frame update
    void Start()
    {
        scoreP1 = 0;
        scoreP2 = 0;
        scoreTextPlayer1.text = scoreP1.ToString();
        scoreTextPlayer2.text = scoreP2.ToString();
    }

    // Update is called once per frame
    public void aumentarPunto(string player) {
        switch (player) {
            case "player1":
                scoreP1++;
                scoreTextPlayer1.text = scoreP1.ToString();
                break;
            case "player2":
                scoreP2++;
                scoreTextPlayer2.text = scoreP2.ToString();
                break;
            default:
                return;
        }
    }
}
