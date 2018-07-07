using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {
    
    #region Variables

    #endregion Variables

    #region MainFunctions

    #endregion MainFunctions

    #region Methods
    public void LoadNextLevel() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +   1);
    }
	#endregion Methods
}	// Main Class
