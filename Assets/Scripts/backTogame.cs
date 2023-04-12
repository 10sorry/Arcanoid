using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backTogame : MonoBehaviour
{
    private bool isresumeMenuOpen = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isresumeMenuOpen)
            {
                SceneManager.LoadScene("Level1");
                isresumeMenuOpen = false;
            }
        }
    }

}
