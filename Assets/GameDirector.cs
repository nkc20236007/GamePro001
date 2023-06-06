using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    GameObject gogo;
    GameObject Timegauge;
    float span = 1;
    float delta = 0;
    float meter = 0;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        this.gogo = GameObject.Find("gogo");
        this.Timegauge = GameObject.Find("Timegauge");
    }
    void Update()
    {
        this.meter += 0.049072f * 20.0f;
        this.gogo.GetComponent<Text>().text = this.meter.ToString("F0") + "km";
        this.delta += Time.deltaTime;
        if(meter > 6000)
        {
            this.gogo.GetComponent<Text>().text = "6000km";
        }

        if (this.delta > this.span)
        {
            this.delta = 0;
            this.Timegauge.GetComponent<Image>().fillAmount -= 0.01f;
        }
    }
    public void DecreaseTime()
    {
        this.Timegauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
