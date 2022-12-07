using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    private enum ButtonFunctionality
    {
        Previous,
        Restart,
        Next,
        Home
    }

    [SerializeField] private ButtonFunctionality _functionality;
    private GameManager gameManager;
    private Button button;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        button = GetComponent<Button>();

        if (_functionality == ButtonFunctionality.Next)
        {
            button.onClick.AddListener(gameManager.LoadNextScene);
            if (SceneManager.GetActiveScene().buildIndex == SceneManager.sceneCountInBuildSettings - 1)
            {
                button.interactable = false;
            }
        }
        else if (_functionality == ButtonFunctionality.Previous)
        {
            button.onClick.AddListener(gameManager.LoadPreviousScene);
            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                button.interactable = false;
            }
        }
        else if (_functionality == ButtonFunctionality.Restart)
        {
            button.onClick.AddListener(gameManager.ReloadScene);
        }
        else
        {
            button.onClick.AddListener(gameManager.LoadHomeScene);
        }
    }
}
