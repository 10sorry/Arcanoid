using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class esc : MonoBehaviour
{
    private bool isresumeMenuOpen = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isresumeMenuOpen)
            {
                SceneManager.LoadScene("Resume");
                isresumeMenuOpen = true;
            }
        }
    }

}

