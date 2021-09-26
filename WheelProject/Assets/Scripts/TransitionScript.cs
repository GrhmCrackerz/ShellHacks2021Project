using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TransitionScript : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public SpinCounterScript spin;
    int var = SpinCounterScript.spinCounter;
    // Update is called once per frame
    void Update()
    {
        if (var <= 0)
        {
            LoadTransition();
        }
    }

    public void LoadTransition()
    {
        StartCoroutine(LoadGameOver(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadGameOver(int levelIndex)
    {
        // Play animation

        transition.SetTrigger("Start");

        // wait

        yield return new WaitForSeconds(transitionTime);

        // Load the next scene

        SceneManager.LoadScene(levelIndex);
    }
}