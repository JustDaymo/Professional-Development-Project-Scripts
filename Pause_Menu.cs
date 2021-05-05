using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_Menu : MonoBehaviour
{
    public GameObject PauseMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (PauseMenu.activeSelf)
            {
                PauseMenu.SetActive(false);
                Time.timeScale = 1f;
            }
            else
            {
                PauseMenu.SetActive(true);
                Time.timeScale = 0f;
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseMenu.activeSelf)
            {
                    PauseMenu.SetActive(false);
                    Time.timeScale = 1f;
            }
            else
            {
                    PauseMenu.SetActive(true);
                    Time.timeScale = 0f;
            }
        }
    }
}