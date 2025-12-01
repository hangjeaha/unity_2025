using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    public AudioClip appleSE;
    public AudioClip bombSE;
    AudioSource aud;
    GameObject director;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        aud = GetComponent<AudioSource>();
        director = GameObject.Find("GameDirector");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Àâ¾Ò´Ù ");
        if (other.gameObject.tag == "Apple")
        {
            Debug.Log("»ç°ú");
            aud.PlayOneShot(appleSE);
            director.GetComponent<GameDirector>().GetApple();
        }
        else if(other.gameObject.tag == "Bomb")
        {
            Debug.Log("ÆøÅº");
            aud.PlayOneShot(bombSE);
            director.GetComponent<GameDirector>().GetBomb();
        }
        Destroy(other.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                float x = Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.z);
                transform.position = new Vector3(x, 0, z);
            }
        }
    }
}
