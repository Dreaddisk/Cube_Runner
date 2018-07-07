using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour {

    #region Variables
    public GameManager gameManager;
    #endregion Variables

    #region MainFunctions

    #endregion MainFunctions

    #region Methods
    private void OnTriggerEnter(Collider other)
    {
        gameManager.CompleteLevel();
    }
    #endregion Methods
}	// Main Class
