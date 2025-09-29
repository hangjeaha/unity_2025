using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    //public GameObject car;
    //public GameObject flag;
    public Transform car;
    public Transform flag;
    public GameObject distance;
    

    // Start is called before the first frame update
    void Start()
    {
        //this.car = GameObject.Find("car");
        //this.flag = GameObject.Find("flag");
        this.car = GameObject.Find("car").transform;
        this.flag = GameObject.Find("flag").transform;
        this.distance = GameObject.Find("distance");
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        this.distance.GetComponent<TextMeshProUGUI>().text = "Distance: " + length.ToString("F2") + "m";
        //TextMeshProUGUI t = distance.GetComponent<TextMeshProUGUI>();
        //t.text = "Distnace: " + length.ToString("F2") + "m";
    }
}
