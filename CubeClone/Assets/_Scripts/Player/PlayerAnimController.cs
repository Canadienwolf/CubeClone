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
        int runMultiplier = input.IsRunning() ? 2 : 1;

        anim.SetFloat("VelX", input.MoveDirection().x * runMultiplier);
        anim.SetFloat("VelY", input.MoveDirection().z * runMultiplier);
        anim.SetBool("Grounded", playerBehavior.Grounded());
        if (input.Attack() && playerBehavior.Grounded())
            anim.SetTrigger("Attack_Light");
        if (input.Jump(playerBehavior.Grounded()))
            anim.SetTrigger("Jump");
    }
}
