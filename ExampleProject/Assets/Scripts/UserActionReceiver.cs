using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserActionReceiver : MonoBehaviour {
    // C# event declarations.
    // Methods can be "added" to each event and will be called when the event is invoked.
    public event Action OnInteractionStart;
    public event Action OnInteractionEnd;
    
    // Property with public getter and private setter.
    // That means that code in other classes can't change the value.
    public bool IsInteracting { get; private set; }

    // Inform this component that an interaction is starting
    public void NotifyInteractionStart() {
        IsInteracting = true;

        // Invoke event
        if (OnInteractionStart != null) {
            OnInteractionStart();
        }
    }

    // Inform this component that an interaction is ending
    public void NotifyInteractionEnd() {
        IsInteracting = false;

        // Invoke event
        if (OnInteractionEnd != null) {
            OnInteractionEnd();
        }
    }
}
