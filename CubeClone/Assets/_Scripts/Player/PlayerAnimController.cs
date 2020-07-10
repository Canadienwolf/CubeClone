using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimController : MonoBehaviour
{
    public Animator anim;
    public PlayerBehavior playerBehavior;

    PlayerInput input = new PlayerInput();

    private void Update()
    {
        anim.SetFloat("VelX", input.MoveDirection().x);
        anim.SetFloat("VelY", input.MoveDirection().z);
        anim.SetBool("Grounded", playerBehavior.Grounded());
        if (input.Jump(playerBehavior.Grounded()))
            anim.SetTrigger("Jump");
    }
}
