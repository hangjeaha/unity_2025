using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RoulletteController : MonoBehaviour
{
    float rotSpeed = 0;
    public float startSpeed = 20f;
    float dRactio = 0.95f;
    float minSpeed = 0.1f;
    bool startDecrease = false;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = this.startSpeed;
        }
        transform.Rotate(0, 0, -rotSpeed);
        if (this.startDecrease)
        {
            this.rotSpeed *= this.dRactio;
        }
        if (this.rotSpeed < this.minSpeed)
        {
            this.rotSpeed = 0f;
        }
    }
}
