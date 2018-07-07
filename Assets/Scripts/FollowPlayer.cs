using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    #region Variables
    public Transform player;
    public Vector3 offset;

    #endregion Variables

    #region MainFunctions
    private void Update()
    {
        transform.position = player.position + offset;

    }
    #endregion MainFunctions

    #region Methods

    #endregion Methods
}	// Main Class
