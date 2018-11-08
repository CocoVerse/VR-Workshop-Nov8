using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightControls : MonoBehaviour {
    public GameObject cameraRig;

    private SteamVR_TrackedObject trackedObject;

    public float speedLow;
    public float speedHigh;

    // Use this for initialization
    void Start () {
        trackedObject = GetComponent<SteamVR_TrackedObject>();
	}
	
	// Update is called once per frame
	void Update () {
        var device = SteamVR_Controller.Input((int)trackedObject.index);
        if(device == null) {
            return;
        }

        var triggerValue = device.GetAxis(Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger).x;

        if (triggerValue < 0.05f) {
            return;
        }

        var maxSpeed = device.GetPress(SteamVR_Controller.ButtonMask.Grip) ? speedHigh : speedLow;

        var speedValue = triggerValue * maxSpeed;

        cameraRig.transform.position += transform.forward * speedValue * Time.deltaTime;
    }
}
