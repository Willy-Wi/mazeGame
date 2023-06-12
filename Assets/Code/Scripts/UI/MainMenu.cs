using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        Button playGame = root.Q<Button>("Play");
        Button quitGame = root.Q<Button>("Quit");

        playGame.clicked += () => PlayGame();
        quitGame.clicked += () =>
        {
            Debug.Log("Player has quit the game");
        };
    }

    private void PlayGame()
    {
        SceneManager.LoadScene(sceneBuildIndex: SceneManager.GetActiveScene().buildIndex + 1);
    }
}
