using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heath : MonoBehaviour
{
    public int maxhealth = 1;
    public float currentHealth;
    public HealthBar healthbar;
    public bouncing _bouncing;

    private void Start()
    {
        currentHealth = maxhealth;
        healthbar = GameObject.Find("_HealthBar").GetComponent<HealthBar>();
        _bouncing = GameObject.FindObjectOfType<bouncing>();
        healthbar.SetMaxHealth(maxhealth);
    }
    
    private void OnCollisionEnter2D(Collision2D otherObject)
    {
        if (otherObject.gameObject.CompareTag("floor"))
        {
            TakeDamage(0.2f);
        }
    }

    private void TakeDamage(float damage)
    {
        currentHealth -= damage;
        _bouncing.BallisNotactivated();
        healthbar.SetHealth(currentHealth);
        Debug.Log(currentHealth);
        if (currentHealth <= 0.25f)
        {
            Debug.Log("You are dead");
            gameObject.SetActive(false);
        }


    }

}
