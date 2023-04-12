using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour
{

    public TextMeshProUGUI myScoreText;
    private int scoreNum = 0;
    public int hitPoints = 1;

    public void Scenechange()
    {
        SceneManager.LoadScene("Level2");
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bricks"))  // если шарик столкнулся с кирпичом
        {
            hitPoints--;
            scoreNum = scoreNum + 1;
            myScoreText.text = ("Score: " + scoreNum);
            Debug.Log(scoreNum);

            if (hitPoints <= 0)  // если кирпич разрушен
            {
                Destroy(other.gameObject);  // удаляем кирпич из игры


            }
            
            if (scoreNum == 142)
            {
                Scenechange();
            }

        }
    }
    

}
