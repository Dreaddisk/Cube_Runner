using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    #region Variables

    // If the cube has collide with an obstacle
    bool gameHasEnded = false;

    // When the game has ended the restart will wait until the
    // counter has gone to 0.
    public float restartDelay = 1.0f;

    public GameObject completeLevelUI;
    #endregion Variables

    #region MainFunctions

    #endregion MainFunctions

    #region Methods
  public void EndGame() {

        if (gameHasEnded == false) {

            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("RestartGame", restartDelay);
        }
    }


    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel() {


        completeLevelUI.SetActive(true);

    }
    #endregion Methods
}	// Main Class
