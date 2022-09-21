using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMovement : MonoBehaviour
{
    [SerializeField] private GameObject[] lights;


    // Start is called before the first frame update
    void Start()
    {
        lights = new GameObject[lights.Length];
       
    }

    // Update is called once per frame
    void Update()
    {
        /*
        for (int i = 0; i < lights.Length; i++)
        {
            if (lights[i].GetComponent<Light>().intensity >= 3)
            {
                lights[i].GetComponent<Light>().intensity = (float) (lights[i].GetComponent<Light>().intensity - 0.1);
            }
            else if (lights[i].GetComponent<Light>().intensity <= 1)
            {
                lights[i].GetComponent<Light>().intensity = (float)(lights[i].GetComponent<Light>().intensity + 0.1);
            }
        }
        
        */
           
        
    }
}
