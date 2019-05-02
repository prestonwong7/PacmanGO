using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    public Slider slider;

    // Update is called once per frame
    void Update()
    {
       FindObjectOfType<AudioManager>().ChangeVolume(slider.value);
    }
}
