using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int maxScore { get; private set; }
    public int scoreCount { get; private set; }
    private int sceneIndex, totalScenes;
    [SerializeField] ScoreUI scoreUI;

    private void Awake()
    {
        maxScore = GameObject.FindGameObjectsWithTag("Yellow Star").Length;
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        totalScenes = SceneManager.sceneCountInBuildSettings;
    }

    public void CheckScore()
    {
        if (scoreCount < maxScore) return;
        SceneManager.LoadScene(sceneIndex + 1);
    }

    public void IncrementScore()
    {
        scoreCount++;
        scoreUI.UpdateScoreUI();
    }
}