using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] public float currentMoveAmount;

    void Start()
    {
        currentMoveAmount = 0.0f;
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 3, -10);
    }

    
    void Update()
    {
        //x axis
        if (player.transform.position.x > Mathf.Abs(transform.position.x + 10))
        {
            moveCamera(Mathf.Abs(player.transform.position.x) - (Mathf.Abs(transform.position.x + 10)), 'x');
            
        }
        else if (player.transform.position.x < Mathf.Abs(transform.position.x - 10))
        {
            moveCamera(((Mathf.Abs(transform.position.x - 10)) - Mathf.Abs(player.transform.position.x)) * -1, 'x');
            
        }
        
        //y axis
        if (player.transform.position.y > Mathf.Abs(transform.position.y + 0))
        {
            moveCamera(Mathf.Abs(player.transform.position.y) - (Mathf.Abs(transform.position.y + 0)), 'y');

        }
        else if (player.transform.position.y < Mathf.Abs(transform.position.y - 0))
        {
            moveCamera(((Mathf.Abs(transform.position.y - 0)) - Mathf.Abs(player.transform.position.y)) * -1, 'y');

        }
        
    }

    private void moveCamera(float moveAmount, char xOrY)
    {
        currentMoveAmount = moveAmount;
        switch (xOrY)
        {
            case 'x':
                transform.position = new Vector3(transform.position.x + moveAmount, transform.position.y, -10);
                break;

            case 'y':
                transform.position = new Vector3(transform.position.x, transform.position.y + moveAmount, -10);
                break;
        }
        
    }
}
