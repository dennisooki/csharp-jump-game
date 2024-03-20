using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpScript : MonoBehaviour
{
    public float jumpForce = 10f;
    private bool isJumping = false;
    public Text scoreText;
    private Rigidbody rb;
    private int points = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
            isJumping = true;
            points++;
            scoreText.text = "Points: " + points;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("New"))
        {
            isJumping = false;
        }
    }
}

