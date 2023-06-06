using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeOver : MonoBehaviour
{
    GameObject Timegauge;

    // Start is called before the first frame update
    void Start()
    {
        this.Timegauge = GameObject.Find("Timegauge");

    }

    // Update is called once per frame
    void Update()
    {
        if(this.Timegauge.GetComponent<Image>().fillAmount == 0) 
        {
            SceneManager.LoadScene("TitleScene");
        }

    }
}
