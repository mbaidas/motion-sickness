using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Newdebug : MonoBehaviour {

    void start()
    {
        if(OVRInput.IsControllerConnected(OVRInput.Controller.Remote)){
            // where X is RTrackedRemote | LTrackedRemote | Remote | RTouch | LTouch 
            Debug.Log("Remote Detected");
        } else {
            Debug.Log("No Remote");
        }

        if (Input.GetKeyDown("space"))
        {
            print("left button pressed");
        }
    }
}
