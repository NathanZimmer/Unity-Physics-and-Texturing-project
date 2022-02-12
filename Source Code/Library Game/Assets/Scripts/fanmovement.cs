using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fanmovement : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    public bool on = true;

    private float offset = 0.1f;
    private float speedCopy;
    private float rotation = 0;

    private void Start()
    {
        speedCopy = speed;
        speed = 0;
    }

    private void FixedUpdate()
    {
        if (on)
        {
            speed = Mathf.Min(speed + offset, speedCopy);
        }
        else
        {
            speed = Mathf.Max(speed - offset, 0);
        }

        rotation -= speed;
        transform.rotation = Quaternion.Euler(90, rotation, 0);
    }
}
