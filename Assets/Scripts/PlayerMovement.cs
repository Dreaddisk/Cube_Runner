using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    #region Variables
    public Rigidbody rb;

    public float forwardForce = 2000f;

    [SerializeField]
    private float _shiftSides = 10.0f;
    [SerializeField]
    private float _jumpForce = 500f;

    #endregion Variables

    #region MainFunctions
    private void Start()
    {

    }

    private void FixedUpdate()
    {
        Movement();
    }
    #endregion MainFunctions

    #region Methods

    public void Movement() {

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {

            rb.AddForce(-_shiftSides * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {

            rb.AddForce(_shiftSides * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1) {

            FindObjectOfType<GameManager>().EndGame();
        }
/*
        else if (Input.GetKeyDown(KeyCode.Space)) {

            rb.AddForce(0, _jumpForce * Time.deltaTime, 0);
        }
*/
    }
    #endregion Methods
}// Main Class
