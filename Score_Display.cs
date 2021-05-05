using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_Display : MonoBehaviour
{
    public GameObject Score;
    private Score SC;

    public TextMeshProUGUI ScoreText1;
    public TextMeshProUGUI ScoreText2;

    void Start()
    {
        SC = Score.GetComponent<Score>();

        ScoreText1.text = "0000000";
        ScoreText2.text = "0000000";
    }

    public void UpdateScore(int Points, bool P1, bool P2)
    {
        if (P1)
        {
            ScoreText1.text = SC.P1Points.ToString("0000000");
        }

        if (P2)
        {
            ScoreText2.text = SC.P2Points.ToString("0000000");
        }
    }
}
