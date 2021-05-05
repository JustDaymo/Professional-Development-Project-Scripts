using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public GameObject HUDScore;
    Score_Display BS;

    public int P1Points = 0000000;
    public int P2Points = 0000000;

    void Start()
    {
        BS = HUDScore.GetComponent<Score_Display>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            P1Points += 111950;
            BS.UpdateScore(P1Points, true, false);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            P2Points += 1950;
            BS.UpdateScore(P2Points, false, true);
        }
    }
}
