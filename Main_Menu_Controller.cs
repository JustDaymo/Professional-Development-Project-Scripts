using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main_Menu_Controller : MonoBehaviour
{
    public Button StartButton;
    public Button HighscoresButton;
    public Button RulesButton;
    public Button CreditsButton;
    void Start()
    {
        Button Start = StartButton.GetComponent<Button>();
        Start.onClick.AddListener(MoveToGame);

        Button Highscores = HighscoresButton.GetComponent<Button>();
        Highscores.onClick.AddListener(MoveToHighscores);

        Button Rules = RulesButton.GetComponent<Button>();
        Rules.onClick.AddListener(MoveToRules);

        Button Credits = CreditsButton.GetComponent<Button>();
        Credits.onClick.AddListener(MoveToCredits);
    }

    void MoveToGame()
    {
        SceneManager.LoadScene("Game");
    }
    void MoveToHighscores()
    {
        SceneManager.LoadScene("Highscores");
    }
    void MoveToRules()
    {
        SceneManager.LoadScene("Rules");
    }
    void MoveToCredits()
    {
        SceneManager.LoadScene("Credits");
    }
}
