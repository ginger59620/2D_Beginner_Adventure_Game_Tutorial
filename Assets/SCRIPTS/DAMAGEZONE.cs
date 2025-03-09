using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DAMAGEZONE : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        PLAYERCONTROLLER controller = other.GetComponent<PLAYERCONTROLLER>();

        if (controller != null)
        {
            controller.ChangeHealth(-1);
        }
    }
}
