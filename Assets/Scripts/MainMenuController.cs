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
        mapLocations = new string[30];
        mapLocations[0] = "33.783169,-118.110267";
        mapLocations[1] = "33.783312,-118.110079";
        mapLocations[2] = "33.783437,-118.110449";
        mapLocations[3] = "33.783853,-118.110118";
        mapLocations[4] = "33.783456,-118.109930";
        mapLocations[5] = "33.783844,-118.110434";
        mapLocations[6] = "33.783786,-118.110412";
        mapLocations[7] = "33.783585,-118.110396";
        mapLocations[8] = "33.783438,-118.110385";
        mapLocations[9] = "33.783162,-118.110262";
        mapLocations[10] = "33.782807,-118.110062"; 
        mapLocations[11] = "33.782459,-118.110040";
        mapLocations[12] = "33.784162,-118.109858";
        mapLocations[13] = "33.784751,-118.109815";
        mapLocations[14] = "33.784412,-118.109686";
        mapLocations[15] = "33.784038,-118.111209";
        mapLocations[16] = "33.783948,-118.111424";
        mapLocations[17] = "33.783601,-118.111445";
        mapLocations[18] = "33.783387,-118.111413";
        mapLocations[19] = "33.783057,-118.111488";
        mapLocations[20] = "33.782798,-118.111456";
        mapLocations[21] = "33.782691,-118.111424";
        mapLocations[22] = "33.782548,-118.111241";
        mapLocations[23] = "33.782703,-118.111029";
        mapLocations[24] = "33.782618,-118.111072";
        mapLocations[25] = "33.783059,-118.111254";
        mapLocations[26] = "33.783269,-118.109908";
        mapLocations[27] = "33.783808,-118.109833";
        mapLocations[28] = "33.783795,-118.109630";
        mapLocations[29] = "33.783817,-118.109265";
    }

    public void ToggleMap2()
    {
        map2 = !map2;
        mapLocations = new string[30];
        mapLocations[0] = "33.781172,-118.112932";
        mapLocations[1] = "33.781729,-118.113527";
        mapLocations[2] = "33.781807,-118.113104";
        mapLocations[3] = "33.781686,-118.112854";
        mapLocations[4] = "33.781423,-118.112741";
        mapLocations[5] = "33.781031,-118.113486";
        mapLocations[6] = "33.781093,-118.113636";
        mapLocations[7] = "33.781147,-118.113416";
        mapLocations[8] = "33.781285,-118.113642";
        mapLocations[9] = "33.781695,-118.113481";
        mapLocations[10] = "33.781744,-118.113636";
        mapLocations[11] = "33.781815,-118.113829";
        mapLocations[12] = "33.781508,-118.113025";
        mapLocations[13] = "33.781329,-118.112896";
        mapLocations[14] = "33.781191,-118.112891";
        mapLocations[15] = "33.780808,-118.113084";
        mapLocations[16] = "33.780848,-118.112993";
        mapLocations[17] = "33.780732,-118.113497";
        mapLocations[18] = "33.781044,-118.112687";
        mapLocations[19] = "33.780906,-118.112880";
        mapLocations[20] = "33.781659,-118.112725";
        mapLocations[21] = "33.781749,-118.112113";
        mapLocations[22] = "33.782021,-118.111759";
        mapLocations[23] = "33.782185,-118.112494";
        mapLocations[24] = "33.782003,-118.113003";
        mapLocations[25] = "33.782052,-118.113571";
        mapLocations[26] = "33.781976,-118.113936";
        mapLocations[27] = "33.780331,-118.113148";
        mapLocations[28] = "33.780308,-118.113416";
        mapLocations[29] = "33.780027,-118.113245";
    }

    public void ToggleMap3()
    {
        map3 = !map3;
        mapLocations = new string[30];
        mapLocations[0] = "33.783169,-118.110267";
        mapLocations[1] = "33.783312,-118.110079";
        mapLocations[2] = "33.783437,-118.110449";
        mapLocations[3] = "33.783853,-118.110118";
        mapLocations[4] = "33.783456,-118.109930";
        mapLocations[5] = "33.783844,-118.110434";
        mapLocations[6] = "33.783786,-118.110412";
        mapLocations[7] = "33.783585,-118.110396";
        mapLocations[8] = "33.783438,-118.110385";
        mapLocations[9] = "33.783162,-118.110262";
        mapLocations[10] = "33.782807,-118.110062";
        mapLocations[11] = "33.782459,-118.110040";
        mapLocations[12] = "33.784162,-118.109858";
        mapLocations[13] = "33.784751,-118.109815";
        mapLocations[14] = "33.784412,-118.109686";
        mapLocations[15] = "33.784038,-118.111209";
        mapLocations[16] = "33.780848,-118.112993";
        mapLocations[17] = "33.780732,-118.113497";
        mapLocations[18] = "33.781044,-118.112687";
        mapLocations[19] = "33.780906,-118.112880";
        mapLocations[20] = "33.781659,-118.112725";
        mapLocations[21] = "33.781749,-118.112113";
        mapLocations[22] = "33.782021,-118.111759";
        mapLocations[23] = "33.782185,-118.112494";
        mapLocations[24] = "33.782003,-118.113003";
        mapLocations[25] = "33.782052,-118.113571";
        mapLocations[26] = "33.781976,-118.113936";
        mapLocations[27] = "33.780331,-118.113148";
        mapLocations[28] = "33.780308,-118.113416";
        mapLocations[29] = "33.780027,-118.113245";
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
