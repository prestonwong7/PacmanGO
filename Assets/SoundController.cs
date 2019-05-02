using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    public void Toggle_Change(bool flag)
    {
        if(flag)
        {
            FindObjectOfType<AudioManager>().Play("BG Music");
        }
        else
        {
            FindObjectOfType<AudioManager>().Stop("BG Music");
        }
    }
}
