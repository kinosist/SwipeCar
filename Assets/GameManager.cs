using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject car;
    public GameObject flag;
    public GameObject distance;
    private bool isOver = false;

    // Start is called before the first frame update
    void Start()
    {
        //this.car = GameObject.Find("car");
        //this.flag = GameObject.Find("flag");
        //this.distance = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update()
    {
        if (!isOver)
        {
            float length = this.flag.transform.position.x - this.car.transform.position.x;
            if (length >= 0)
            {
                this.distance.GetComponent<TextMeshProUGUI>().text = "ÉSÅ[ÉãÇ‹Ç≈" + length.ToString("F2") + "m";
            }
            else
            {
                this.distance.GetComponent<TextMeshProUGUI>().text = "GAME OVER";
                isOver = true;
            }
        }

    }
}
