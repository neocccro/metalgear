using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public float speed = 6.0f;
    public float gravity = 20.0f;
    public Vector3 moveDirection = Vector3.zero;

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {

            moveDirection = new Vector3(0, 0, Mathf.Min(Mathf.Abs(Input.GetAxis("Horizontal"))+Mathf.Abs(Input.GetAxis("Vertical")),1));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            //controller.
        }
        moveDirection.y = -gravity * Time.deltaTime * 40;
        controller.Move(moveDirection * Time.deltaTime);
        //transform.Rotate(Vector3.up * Time.deltaTime * 200);
        //Debug.Log(transform.localEulerAngles.y);
        //Debug.Log(Input.GetAxis("Horizontal"));
        //Debug.Log(Vector2.Angle(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")),new Vector2(0,0)));
    }
}
