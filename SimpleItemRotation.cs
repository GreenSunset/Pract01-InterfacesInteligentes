using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleItemRotation : MonoBehaviour
{
    public float rotationSpeed = 90.0f;
    public float oscilationSpeed = 5f;
    public float oscilationAmplitude = 4f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        // Go up and down
        transform.Translate(Vector3.up * oscilationAmplitude * Mathf.Sin(oscilationSpeed * Time.time) * Time.deltaTime);
    }
}
