using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PROJECTILE : MonoBehaviour
{
    Rigidbody2D rigidbody2d;

    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();   
    }

    void Update()
    {
       if (transform.position.magnitude > 100.0f)
        {
            Destroy(gameObject);
        }
    }

    public void Launch(Vector2 direction, float force)
    {
        rigidbody2d.AddForce(direction * force);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        ENEMYCONTROLLER enemy = other.GetComponent<ENEMYCONTROLLER>();
        if (enemy != null)
        {
            enemy.Fix();
        }

        Destroy(gameObject);
    }
   
}
