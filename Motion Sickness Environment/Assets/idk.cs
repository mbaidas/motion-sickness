using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idk : MonoBehaviour {

	// Use this for initialization
	
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("left button pressed");
        }

        if (OVRInput.Get(OVRInput.Button.DpadLeft))
        {
            Debug.Log("left button pressed");
        }
    }
}
