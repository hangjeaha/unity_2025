using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class ArrowGenrator : MonoBehaviour
{
    public GameObject arrowPrefab;
    
    float span = 1.0f;
    float delta = 0f;

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(arrowPrefab);
            float px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
