using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SayName : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My name is " + gameObject.name);
    }

}
