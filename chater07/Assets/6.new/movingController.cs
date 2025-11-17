using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotateSpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xspeed = xInput * rotateSpeed * Time.deltaTime;
        float zspeed = zInput * moveSpeed * Time.deltaTime;

        transform.Translate(0, 0, zspeed);
        transform.Rotate(0, xspeed, 0);
    }
}
