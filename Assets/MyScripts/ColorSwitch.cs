using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwitch : MonoBehaviour
{
    public GameObject newObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            newObject.GetComponent<Renderer>().material.color = Color.red;
        }
        
        if (Input.GetKeyDown(KeyCode.Y))
        {
            newObject.GetComponent<Renderer>().material.color = Color.yellow;
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            newObject.GetComponent<Renderer>().material.color = Color.green;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            newObject.GetComponent<Renderer>().material.color = Color.cyan;
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            newObject.GetComponent<Renderer>().material.color = Color.magenta;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            newObject.GetComponent<Renderer>().material.color = Color.black;
        }
    }
}
