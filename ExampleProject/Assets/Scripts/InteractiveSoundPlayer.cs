using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveSoundPlayer : MonoBehaviour {
    public UserActionReceiver receiver;
    public AudioSource source;

	// Use this for initialization
	void Start () {
        receiver.OnInteractionStart += PlaySound;
	}

    private void PlaySound() {
        source.Play();
    }
}
