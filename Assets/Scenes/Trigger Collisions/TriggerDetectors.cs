using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetectors : MonoBehaviour
{
    public GameObject theLight;

    public bool lightIsOn = true;

    public GameObject leCube;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (lightIsOn == true)
        {
            theLight.SetActive(true);
        }
        else
        {
            theLight.SetActive(false);
        }
	}

    void OnTriggerEnter()
    {
        print("yeets");
        lightIsOn = !lightIsOn;
        Destroy(leCube);
    }

    void OnTriggerExit()
    {
        print("poo");
        lightIsOn = !lightIsOn;
    }
}
