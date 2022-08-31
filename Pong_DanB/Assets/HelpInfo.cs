using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpInfo : MonoBehaviour
{
    public static bool hGamePaused = false;
    public GameObject HelpInfoUI;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (hGamePaused)
            {
                hResume();
            }
            else
            {
                hPause();
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Quitting Game.");
        }
    }
    public void hResume()
    {
        HelpInfoUI.SetActive(false);
        Time.timeScale = 1f;
        hGamePaused = false;
    }

    void hPause()
    {
        HelpInfoUI.SetActive(true);
        Time.timeScale = 0f;
        hGamePaused = true;
    }
}

