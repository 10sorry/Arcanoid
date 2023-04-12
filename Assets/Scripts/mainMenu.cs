using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void Menu(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OnButtonClick()
    {
        SceneManager.LoadScene("Menu");
    }

}
