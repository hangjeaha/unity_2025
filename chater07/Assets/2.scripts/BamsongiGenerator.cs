using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;

    // Start is called before the first frame update
    void Start()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject go = Instantiate(bamsongiPrefab);
             go.transform.position = new Vector3(transform.position.x, transform.position.y+1, transform.position.z+1);
        
            go.GetComponent<bamsongiPrefab>().Shoot(new Vector3(0, 800, 2000));
        }
    }
}
