using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpForce = 200.0f;
    public float walkForce = 30.0f;
    public float maxWalkSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * jumpForce);
        }

        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        float speedx = Mathf.Abs(rb.velocity.x);

        if (speedx < maxWalkSpeed)
        {
            rb.AddForce(transform.right * key * walkForce);
        }

        if(key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }
    }
}
