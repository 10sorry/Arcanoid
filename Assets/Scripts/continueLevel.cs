using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class continueLevel : MonoBehaviour
{
    public int Level;
    public void Continue(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OnButtonClick()
    {
        SceneManager.LoadScene("Level1");
    }

}
