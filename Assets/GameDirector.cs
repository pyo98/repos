using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameDirector : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject car;
    GameObject flag;
    GameObject distance;
    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");

    }

    // Update is called once per frame
    void Update()
    {
        float length=this.flag.transform.position.x-this.car.transform.position.x;
        if(length >= 0 ) 
        {
            this.distance.GetComponent<TextMeshProUGUI>().text = "�Ÿ� : " + length.ToString("F2") + "m";
        }
        else
        {
            this.car.GetComponent<NewBehaviourScript>().SpeedZero();
            this.distance.GetComponent<TextMeshProUGUI>().text = "GameOver";
        }
    }
}
