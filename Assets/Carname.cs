using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Carname : MonoBehaviour
{
    GameObject carname;
    // Start is called before the first frame update
    void Start()
    {
        this.carname = GameObject.Find("carname");
        this.carname.GetComponent<TextMeshProUGUI>().text = "자동차 경주";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
