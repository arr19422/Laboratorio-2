using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody rb;
    public float force;
    public float JumpForce;
    public GameObject[]  powerUps;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    void FixedUpdate()
    {
        if (rb)
        {
            rb.AddForce(Input.GetAxis("Horizontal") * force, 0, Input.GetAxis("Vertical") * force);
        }
    }

    private void Jump()
    {
        if (rb)
        {
            if (Mathf.Abs(rb.velocity.y) < 0.0005f)
            {
                rb.AddForce(0, JumpForce, 0, ForceMode.Impulse);
            }   
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        powerUps = GameObject.FindGameObjectsWithTag("Coin");

        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Lava") && powerUps.Length != 0)
        {
            Destroy(gameObject);
        }
    }

    
}
