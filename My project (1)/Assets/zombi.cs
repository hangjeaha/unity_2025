using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombi_contriler : MonoBehaviour
{
    public class Transform player
    
    void Start()
    {
        player = new player(100, 20);
        float a = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f, 0f, 0.01f);

        player.Damage(10);
    }

    private void OncollisionEnter(collision collision)
    {
        player.Damage(10);
    }
}