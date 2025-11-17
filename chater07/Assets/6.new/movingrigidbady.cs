using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingregid : MonoBehaviour
{
    public float MoveSpeed = 0.1f;
    public float rotateSpeed = 0.2f;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");
    
        float rospeed = xInput * rotateSpeed * Time.deltaTime;
        rb.rotation = rb.rotation * Quaternion.Euler(0, rospeed, 0);
   
        Vector3 move = zInput * transform.forward * MoveSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + move);
    }
}
