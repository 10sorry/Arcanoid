using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMove : MonoBehaviour
{
    private float moving;
    public float moveSpeed = 5f;


    private void Update()
    {
        moving = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(moving, 0f);

        float horizontalExtent = GameManager.instance.horizontalExtent;
        float leftLimit = -horizontalExtent;
        float rightLimit = horizontalExtent;
        
        float newPositionX = Mathf.Clamp(transform.position.x + movement.x * moveSpeed * Time.deltaTime, leftLimit, rightLimit);
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
    }

}
