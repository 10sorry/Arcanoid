using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncing : MonoBehaviour
{
    public int maxhealth = 1;
    public float currentHealth;
    public HealthBar healthbar;
    private Rigidbody2D rb;
    [SerializeField] private GameObject platform;
    private bool isActive = false;
    private Vector3 platformPosition;
    private const float OffsetY = 0.2f;
    private const float Force = 300f;
    private const float OffsetX = 100f;

    void Start()
    {
        currentHealth = maxhealth;
        healthbar = GameObject.Find("_HealthBar").GetComponent<HealthBar>();
        healthbar.SetMaxHealth(maxhealth);
        rb = GetComponent<Rigidbody2D>();
        platformPosition = platform.transform.position;
        rb.bodyType = RigidbodyType2D.Kinematic;
        transform.position = new Vector3(platformPosition.x, platformPosition.y + OffsetY, platformPosition.z);
        transform.SetParent(platform.transform);
        
    }

    private void Update()
    {
        platformPosition = platform.transform.position;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            BallActivated();
            if(isActive == false)
            {
                return;
            }

        }
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
        BallisNotactivated();
        isActive = false;
        healthbar.SetHealth(currentHealth);
        Debug.Log(currentHealth);
        if (currentHealth <= 0.25f)
        {
            Debug.Log("You are dead");
            gameObject.SetActive(false);
        }


    }

    private void BallActivated()
    {
        isActive = false;
        transform.SetParent(null);
        rb.bodyType = RigidbodyType2D.Dynamic;
        rb.AddForce(new Vector2(OffsetX, Force));

    }

    public void BallisNotactivated()
    {
        rb.velocity = Vector2.zero;
        rb.bodyType = RigidbodyType2D.Kinematic;
        transform.SetParent(platform.transform);
        transform.position = new Vector3(platformPosition.x, platformPosition.y + OffsetY, platformPosition.z);
    }



}
