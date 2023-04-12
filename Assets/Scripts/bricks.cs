using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class bricks : MonoBehaviour
{
    public int hitPoints = 1;  // количество ударов, необходимых для разрушения кирпича
    public TextMeshProUGUI myScoreText;
    private int scoreNum = 0;


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ball"))  // если шарик столкнулся с кирпичом
        {
            hitPoints--;
            scoreNum = scoreNum + 1;
            Debug.Log(scoreNum);

            if (hitPoints <= 0)  // если кирпич разрушен
            {
                Destroy(gameObject);  // удаляем кирпич из игры


            }

        }
    }


}
