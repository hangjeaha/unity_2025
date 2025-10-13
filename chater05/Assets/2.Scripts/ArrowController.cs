using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    public float dropSpeed = 0.1f;
    public float playerRadius = 0.7f;
    public float arrowRadius = 0.3f;

    Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = 
            GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -dropSpeed, 0);

        if(transform.position.y < -6f)
        {
            Destroy(gameObject);
        }

        Checkcollision();
    }
    void Checkcollision()
    {
        Vector2 arrowPosition = transform.position;
        Vector2 playerPosition = playerTransform.position;
        float distance = (arrowPosition - playerPosition).magnitude;

        if(distance < arrowRadius + playerRadius)
        {
            Destroy(gameObject);
        }
    }
}
