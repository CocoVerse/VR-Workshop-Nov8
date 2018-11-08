using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowCycle : MonoBehaviour {
    // Drag-n-drop slots for related components
    public Renderer target;
    public UserActionReceiver actionReceiver;

    // These parameters can also be configured in the inspector
    public float rateOfChange = 1;
    public float maxSize = 1.5f;

    private float value = 0;

    // Update is called once per frame
    void Update () {
        // If the action receiver isn't being focused, increment our value
        if (!actionReceiver.IsInteracting) {

            value += rateOfChange * Time.deltaTime;

            // Modulo division to keep value between 0 and 1
            value %= 1;
        }

        // Get color with our value as its hue
        var currentColor = Color.HSVToRGB(value, 1, 1);

        // Map value onto sine wave
        var sineWaveValue = Mathf.Sin(value * Mathf.PI);

        // Assign transparency
        currentColor.a = sineWaveValue;

        // Assign color to our renderer's material
        target.material.color = currentColor;

        // Interpolate to get intended size
        var sizeValue = Mathf.Lerp(1, maxSize, sineWaveValue);

        // Set scale of the attached transform
        transform.localScale = new Vector3(sizeValue, sizeValue, sizeValue);
    }
}
