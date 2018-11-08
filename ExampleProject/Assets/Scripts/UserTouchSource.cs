using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserTouchSource : MonoBehaviour {
    // TODO: Keep list of receivers that we're touching with this hand
    // to allow us to interact with multiple objects at once
    
    // TODO: Button and trigger input

    public void OnTriggerEnter(Collider other) {
        var receiver = other.GetComponent<UserActionReceiver>();
        if (receiver != null) {
            receiver.NotifyInteractionStart();
        }
        
    }

    private void OnTriggerExit(Collider other) {
        var receiver = other.GetComponent<UserActionReceiver>();
        if(receiver != null) {
            receiver.NotifyInteractionEnd();
        }
    }
}
