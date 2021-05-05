using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Back_Button : MonoBehaviour
{
    public Button BackButton;
    void Start()
    {
        Button Back = BackButton.GetComponent<Button>();
        Back.onClick.AddListener(BackToMenu);
    }

    void BackToMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }
}