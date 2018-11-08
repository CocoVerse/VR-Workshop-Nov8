using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserGazeSource : MonoBehaviour {
    private UserActionReceiver currentTarget;

	// Update is called once per frame
	void Update () {
        AttemptRaycast();
	}

    private void AttemptRaycast() {
        // Declare variable to store results of successful raycast
        RaycastHit hit;

        // Perform raycast operation
        if (Physics.Raycast(transform.position, transform.forward, out hit)) {
            var receiver = hit.collider.GetComponent<UserActionReceiver>();
            if(receiver != null) {
                // Handle the new receiver
                HandleReceiverFound(receiver);
                // Exit early
                return;
            }
        }
        // If we've reached this point, either the raycast has missed or our target has no action receiver
        HandleReceiverMissed();
    }
    private void HandleReceiverMissed() {
        if(currentTarget != null) {
            // Stop interacting with current target
            currentTarget.NotifyInteractionEnd();
            currentTarget = null;
        }
    }

    private void HandleReceiverFound(UserActionReceiver receiver) {
        // Check whether we're already interacting with something
        if(currentTarget != null) {
            if (currentTarget == receiver) {
                // Exit early if we're already interacting with this receiver
                return;
            } else {
                // Otherwise, stop interacting with the current target
                currentTarget.NotifyInteractionEnd();
            }
        }
        // Start interacting with a new target
        currentTarget = receiver;
        receiver.NotifyInteractionStart();
    }
}
