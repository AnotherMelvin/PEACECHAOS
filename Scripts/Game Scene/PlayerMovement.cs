using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {
    
    public PlayerController controller;
    public MechanicManager managerPlayer;
    public GameObject startPos;
    public Animator animator;
    public float runSpeed = 40f;
    float horizonMove = 0f;
    bool jump = false;
    
    void Start() {
        transform.position = startPos.transform.position;
    }

    void Update() {
        horizonMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizonMove));

        if (Input.GetButtonDown("Jump")) {
            jump = true;
            animator.SetBool("IsJumping", true);
        }

        if (managerPlayer.reset == 1) {
            transform.position = startPos.transform.position;
            managerPlayer.level = 0;
            managerPlayer.gameMood = 0;
            managerPlayer.reset = 0;
        }
    }

    public void OnLanding() {
        animator.SetBool("IsJumping", false);
    }

    void FixedUpdate() {
        controller.Move(horizonMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

    
}
