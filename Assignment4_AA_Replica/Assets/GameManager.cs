using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;

    public Rotator rotator;
    public Spawner spawner;

    //public Text remainingLives;

    public Animator animator;

    public void Awake()
    {
        
    }

    

    public void Loss()
    {
        //lives variable - 1

        //clock pause

        rotator.enabled = false;
        spawner.enabled = false;

        animator.SetTrigger("EndGame");
        animator.SetTrigger("Idle");

        gameHasEnded = true;
        Debug.Log("LOSE!");
    }

    public void EndGame()
    {
        if (gameHasEnded)
        {
            return;
        }

        rotator.enabled = false;
        spawner.enabled = false;

        animator.SetTrigger("EndGame");

        gameHasEnded = true;
        Debug.Log("END GAME");
    }

    // RestartLevel() is used as an Event in the animation window
    public void RestartLevel()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Score.remainingLives--;
        gameHasEnded = false;
        rotator.enabled = true;
        spawner.enabled = true;
    }
}
