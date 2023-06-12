using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour {
    private void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        Button backToMainMenu = root.Q<Button>("BackToMainMenu");

        backToMainMenu.clicked += () => BackToMainMenu();
    }

    private void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}