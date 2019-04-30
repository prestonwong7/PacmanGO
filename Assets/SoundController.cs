using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    GameObject onOffToggle;
    bool result = false;

    private void Start()
    {
        onOffToggle = GameObject.Find("On/Off Toggle");
        result = onOffToggle.GetComponent<Toggle>().isOn;
        Debug.Log("Result is: " + result);
        FindObjectOfType<AudioManager>().Stop("BG Music");
    }

    private void Update()
    {
        //Debug.Log("Result is: " + result);
    }
    //public void checkValue()
    //{
    //    bool result = onOffToggle.GetComponent<Toggle>().isOn;
    //    Debug.Log("Result is: " + result);

    //}

}
