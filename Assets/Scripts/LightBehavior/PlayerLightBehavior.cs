using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLightBehavior : MonoBehaviour
{
    [SerializeField] GameObject player;

    Vector3 playerPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, 0);


    }
}
