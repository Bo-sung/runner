﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(destroySelf))]
public class ItemScr : MonoBehaviour
{
    public destroySelf destroy;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            destroy.activation = true;
        }
        
    }
}
