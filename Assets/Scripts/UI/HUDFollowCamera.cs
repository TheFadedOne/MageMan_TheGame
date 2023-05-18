using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDFollowCamera : MonoBehaviour
{
    [SerializeField] Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = camera.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y, 0);
    }
}
