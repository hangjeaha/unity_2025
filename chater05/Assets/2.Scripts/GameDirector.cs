using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public GameObject hPGauge;

    public void DecreaseHP()
    {
        this.hPGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.hPGauge = GameObject.Find("hpGauge");
    }

    // Update is called once per frame
    void Update()
    {
        this.hPGauge.GetComponent<Image>().fillAmount -= 0.01f;
    }
}
