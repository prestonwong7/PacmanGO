using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    bool map1 = false;
    bool map2 = false;
    bool map3 = false;
    string[] mapLocations;

    public void ToggleMap1()
    {
        map1 = !map1;
        mapLocations = new string[5];
        mapLocations[0] = "33.783169,-118.110267";
        mapLocations[1] = "33.783312,-118.110079";
        mapLocations[2] = "33.783437,-118.110449";
        mapLocations[3] = "33.783853,-118.110118";
        mapLocations[4] = "33.783456,-118.109930";
    }

    public void ToggleMap2()
    {
        map2 = !map2;
        mapLocations = new string[5];
        mapLocations[0] = "33.781172,-118.112932";
        mapLocations[1] = "33.781729,-118.113527";
        mapLocations[2] = "33.781807,-118.113104";
        mapLocations[3] = "33.781686,-118.112854";
        mapLocations[4] = "33.781423,-118.112741";
    }

    public void ToggleMap3()
    {
        map3 = !map3;
        mapLocations = new string[5];
        mapLocations[0] = "34.053979,-118.133959";
        mapLocations[1] = "34.053903,-118.133771";
        mapLocations[2] = "34.053827,-118.133589";
        mapLocations[3] = "34.054316,-118.133761";
        mapLocations[4] = "34.054563,-118.133630";
    }
    public void PlayGame()
    {
        PlayerPrefsX.SetStringArray("mapLocations", mapLocations);
        SceneManager.LoadScene("WorldScaleAR");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
