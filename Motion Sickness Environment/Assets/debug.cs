using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debug : MonoBehaviour {


    void Update()
    {
        //OVRInput.Update(); // Call before checking the input
        // if (OVRInput.IsControllerConnected(OVRInput.Controller.Remote))
        // {
        //     print("i");
        // }

        if (Input.GetKeyDown("space"))
        {
            print("left button pressed");
        }

        if (OVRInput.Get(OVRInput.Button.DpadLeft))
        {
            Debug.Log("left button pressed");
        }
        if (OVRInput.Get(OVRInput.Button.DpadRight))
        {
            print("right button pressed");
        }
        if (OVRInput.Get(OVRInput.Button.One))
        {
            print("round button pressed");
        }
    }
}


