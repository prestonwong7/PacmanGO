using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInstance : MonoBehaviour
{
    public static PlayerInstance instance;

    private void Awake()
    {
        instance = this;
    }
}
