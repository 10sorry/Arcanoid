using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCreator : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    [SerializeField] private GameObject platform;
    private Vector3 platformPosition;
    private const float OffsetY = 0.2f;

    public void Start()
    {
        platformPosition = platform.transform.position;
    }

    public void Update()
    {
        BallStart();
    }

    public void BallStart()
    {
        ball.transform.position = new Vector3(platformPosition.x, platformPosition.y + OffsetY, platformPosition.z);
    }
}
