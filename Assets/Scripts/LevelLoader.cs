using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public static LevelLoader Instance { get; private set; }

    public Animator transition;
    public float transitionTime = 1f;


    private void Awake()
    {
        if (Instance == null) { Instance = this; }
    }

    void Update()
    {
        if (Keyboard.current.kKey.wasPressedThisFrame)
        {
            if (SceneManager.GetActiveScene().buildIndex >= SceneManager.sceneCountInBuildSettings - 1)
            {
                LoadMainMenu();
            }
            else
            {
                LoadNextLevel();
            }
        }
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void LoadMainMenu()
    {
        StartCoroutine(LoadLevel(0));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        Debug.Log("ANIMATION TRIGGERED!");
        Time.timeScale = 1f;
        
        if (transition != null)
        {
        transition.SetTrigger("Start");
        }

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }

}
