using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class MainMenuUI : MonoBehaviour
{


    [SerializeField] private Button playButton;
    [SerializeField] private Button quitButton;


    private void Awake()
    {
        playButton.onClick.AddListener(() =>
        {
            GameManager.ResetStaticData();
            LevelLoader.Instance.LoadNextLevel();
        });

        quitButton.onClick.AddListener(() =>
        {
            Application.Quit();
        });
    }
    private void Update()
    {
        if (Keyboard.current.enterKey.wasPressedThisFrame)
        {
            LevelLoader.Instance.LoadNextLevel();
        }
    }

    // private void Start()
    // {
    //     playButton.Select();
    // }

}
