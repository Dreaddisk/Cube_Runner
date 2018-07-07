using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    #region Variables
    public PlayerMovement movement;
    #endregion Variables

    #region MainFunctions

    #endregion MainFunctions

    #region Methods
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle") {

            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }

    }
    #endregion Methods
}	// Main Class
