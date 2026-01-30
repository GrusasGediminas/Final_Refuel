using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] private Button mainMenuButton;
    [SerializeField] private TextMeshProUGUI scoreTextMesh;

    private void Awake()
    {
        mainMenuButton.onClick.AddListener(() =>
        {
            GameManager.ResetStaticData();
            //SceneLoader.LoadScene(SceneLoader.Scene.MainMenuScene);
            LevelLoader.Instance.LoadMainMenu();
        }); 
    }

    private void Start()
    {
        if (GameManager.Instance != null)
        {
            scoreTextMesh.text = "FINAL SCORE: " + GameManager.Instance.GetTotalScore().ToString();
        }
        else
        {
            scoreTextMesh.text = "FINAL SCORE: 0";
        }

        //mainMenuButton.Select();
    }

    private void Update()
    {
        if (Keyboard.current.enterKey.wasPressedThisFrame)
        {
            GameManager.ResetStaticData();
            //SceneLoader.LoadScene(SceneLoader.Scene.MainMenuScene);
            LevelLoader.Instance.LoadMainMenu();
        }
    }
}