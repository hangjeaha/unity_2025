using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameDirector : MonoBehaviour
{
    GameObject timerText;
    GameObject pointText;
    float time = 60.0f;
    int point = 0;

    public void GetApple()
    {
        point += 10;
    }

    public void GetBomb()
    {
        point /= 2;
    }

    // Start is called before the first frame update
    void Start()
    {
        timerText = GameObject.Find("Time");
        pointText = GameObject.Find("Point");
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timerText.GetComponent<TextMeshProUGUI>().text = time.ToString("F1");
        pointText.GetComponent<TextMeshProUGUI>().text = point.ToString() + "point";
    }
}