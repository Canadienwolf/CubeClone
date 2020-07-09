using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerBehavior : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float gravityForce = -9.8f;
    public float jumpHeight = 2f;
    public Camera cam;

    CharacterController charCtrl;
    PlayerInput pInput = new PlayerInput();

    private float vertVel;

    void Start()
    {
        charCtrl = GetComponent<CharacterController>();
    }

    void Update()
    {
        Jump();
        Move();

        transform.rotation = Quaternion.Euler(0, cam.transform.rotation.eulerAngles.y, 0);
    }

    void Jump()
    {
        if (charCtrl.isGrounded && vertVel < 0)
        {
            vertVel = -2;
        }

        if (pInput.Jump(charCtrl.isGrounded))
        {
            vertVel = Mathf.Sqrt(jumpHeight * -2 * gravityForce);
        }

        vertVel += gravityForce * Time.deltaTime;

        charCtrl.Move(Vector3.up * vertVel * Time.deltaTime);
    }

    void Move()
    {
        if (pInput.IsMoving())
        {
            charCtrl.Move(transform.TransformDirection(pInput.MoveDirection()) * Time.deltaTime * moveSpeed);
        }
    }
}
