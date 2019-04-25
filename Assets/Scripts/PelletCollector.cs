using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mapbox.Unity.Map;

public class PelletCollector : MonoBehaviour
{

    public int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(Wait());
    }

    // Have to wait for 5 seconds because all pellets spawn on pacman for some reason
    IEnumerator Wait()
    {
        print(Time.time);
        yield return new WaitForSeconds(5);
        print(Time.time);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pellet")
        {

            count++;
            Debug.Log("Collected Pellets: " + count);

            //other.gameObject.SetActive(false);
            Destroy(other.gameObject);
        }
    }
}
