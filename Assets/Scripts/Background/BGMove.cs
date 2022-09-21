using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMove: MonoBehaviour
{
    [SerializeField] public Camera camera;
    [SerializeField] private float yPos;
    private CameraMovement cm;
    [Range (0, 1)][SerializeField] private float bgOffsetIncrement = 0.0f;
    private float bgOffsetTotal = 0.0f;

    private void Start()
    {
        cm = camera.GetComponent<CameraMovement>();
    }

    void Update()
    {
        if (cm.currentMoveAmount > 0 && Input.GetKey(KeyCode.D) && Mathf.Abs(camera.velocity.x) > 0.1f)
        {
            bgOffsetTotal -= bgOffsetIncrement;
        }
        else if (cm.currentMoveAmount < 0 && Input.GetKey(KeyCode.A) && Mathf.Abs(camera.velocity.x) > 0.1f)
        {
            bgOffsetTotal += bgOffsetIncrement;
        }

        transform.position = new Vector3(camera.transform.position.x + bgOffsetTotal, yPos, 0);

    }
}
