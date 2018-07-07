using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    #region Variables
    public Transform player;
    public Text scoreText;
    #endregion Variables

    #region MainFunctions
    private void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
    #endregion MainFunctions

    #region Methods

    #endregion Methods
}	// Main Class
