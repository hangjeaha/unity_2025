using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetController : MonoBehaviour
{
    ganeratetarget gt;

    // Start is called before the first frame update
    void Start()
    {
        gt = GameObject.FindObjectOfType<ganeratetarget>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Collision.gameObject.tag.Equals("bamsongiPrefab")){
            gt.Generate();
            Destroy(gameObject);
        }
    }
}