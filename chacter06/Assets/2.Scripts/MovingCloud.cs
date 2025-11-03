using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCloud : MonoBehaviour
{
    public float avgSpeed = 0.05f;
    float max = 12.0f;
    int dir = 1;
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(avgSpeed * 0.6f, avgSpeed * 1.4f);
        dir = Random.Range(0, 2) == 0 ? -1 : 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * dir, 0, 0);
        
        if (transform.position.x > max)
        {
            dir = -1;
            speed = Random.Range(avgSpeed * 0.6f, avgSpeed * 1.4f);
        }
        else if (transform.position.x < -max)
        {
            dir = 1;
            speed = Random.Range(avgSpeed * 0.6f, avgSpeed * 1.4f);
        }
    }
}
