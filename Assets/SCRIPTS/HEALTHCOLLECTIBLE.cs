using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HEALTHCOLLECTIBLE : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        PLAYERCONTROLLER controller = other.GetComponent<PLAYERCONTROLLER>();

        if (controller != null && controller.health< controller.maxHeath)
        {
            controller.ChangeHealth(1);
            Destroy(gameObject);
        }
    }
}
