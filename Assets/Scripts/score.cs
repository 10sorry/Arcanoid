using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text myScoreText;
    private int scoreNum;

    private void Start()
    {
        scoreNum = 0;
        myScoreText.text = ("Score: " + scoreNum);
    }


}
