using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Kills : MonoBehaviour
{

    public Text killText;
    public static int killCount = 0;
    // Use this for initialization
    void Start()
    {
        killText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        killText.text = "Kills: " + killCount;
    }

}  
