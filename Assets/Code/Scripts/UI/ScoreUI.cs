using UnityEngine;
using UnityEngine.UIElements;

public class ScoreUI : MonoBehaviour
{
    private VisualElement root;
    [SerializeField] private Score score;
    private Label scoreUI;

    private void Start()
    {
        root = GetComponent<UIDocument>().rootVisualElement;
        // Find Element with the id 'Values'.
        scoreUI = root.Q<Label>("Values");
        UpdateScoreUI();
    }

    public void UpdateScoreUI()
    {
        scoreUI.text = score.GetScore() + "/" + score.GetMaxScore();
    }
}