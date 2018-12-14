using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public CharacterController2D contoller;
    public float runSpeed = 30f;
    bool jump = false;
    float horizontalMove = 0f;
	
	void Update () {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
	}

    private void FixedUpdate()
    {
        contoller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
