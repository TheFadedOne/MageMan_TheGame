using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    [SerializeField]private GameObject camera;

    private Vector3 cameraPosition;
    private int ypos;

    
    void Start()
    {
        cameraPosition = camera.transform.position - camera.transform.position;
    }

    
    void Update()
    {
        transform.position = new Vector3(camera.transform.position.x, 100, 0);
      
    }
}
