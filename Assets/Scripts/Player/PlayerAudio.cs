using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    private AudioSource A;
    private GameObject player;
    private Rigidbody2D bod;
    private Animator animator;

    void Start()
    {
        A = GetComponent<AudioSource>();
        player = GameObject.Find("Player");
        bod = player.GetComponent<Rigidbody2D>();
        animator = player.GetComponent<Animator>();
    }

    
    void Update()
    {
        if (Input.GetButtonDown("Jump") && animator.GetBool("isJumping") == false)
        {
            A.Play();
        }
    }
}
