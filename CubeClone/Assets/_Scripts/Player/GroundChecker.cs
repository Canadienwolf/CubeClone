﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    public float fallHeight;
    public bool isGrounded;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player")
        {

        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag != "Player")
        {

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag != "Player")
        {

        }
    }
}
