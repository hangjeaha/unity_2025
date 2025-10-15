using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public GameObject hPGauge;
    
    public void DecreaseHP()
    {
               hPGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
