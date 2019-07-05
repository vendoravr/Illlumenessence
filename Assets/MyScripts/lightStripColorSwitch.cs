using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Vehicles.Car
{
    public class lightStripColorSwitch : MonoBehaviour
    {
        public CarController car;

        public GameObject lightStrip;

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            Color salmon = new Color32(220, 86, 94, 255);

            if (car.BrakeInput > 0f)
            {
                lightStrip.GetComponent<Renderer>().material.EnableKeyword("_EmissionColor");
                lightStrip.GetComponent<Renderer>().material.SetColor("_EmissionColor", salmon);
                lightStrip.GetComponent<Renderer>().material.color = new Color32(150, 26, 33, 255);
            }

            else
            {
                lightStrip.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 0);
                lightStrip.GetComponent<Renderer>().material.EnableKeyword("_EmissionColor");
                lightStrip.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.black);
            }
            }
    }
}