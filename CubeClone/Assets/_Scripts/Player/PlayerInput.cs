using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput
{
    public Vector3 MoveDirection()
    {
        return new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

    public bool IsMoving()
    {
        return MoveDirection() != Vector3.zero;
    }

    public bool IsRunning()
    {
        return IsMoving() && Input.GetKey(KeyCode.LeftShift);
    }

    public bool Jump(bool grounded)
    {
        return grounded && Input.GetKeyDown("space");
    }

    public bool Interact()
    {
        return Input.GetKeyDown("e");
    }

    public bool Attack()
    {
        return Input.GetMouseButtonDown(0);
    }

    public bool Block()
    {
        return Input.GetMouseButtonDown(1);
    }
}
