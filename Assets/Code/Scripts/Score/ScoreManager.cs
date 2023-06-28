using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int maxScore { get; private set; }
    public int scoreCount { get; private set; }
    private int sceneIndex = SceneManager.GetActiveScene().buildIndex;
    private int totalScenes = SceneManager.sceneCountInBuildSettings;
    [SerializeField] ScoreUI scoreUI;

    private void Awake()
    {
        maxScore = GameObject.FindGameObjectsWithTag("Yellow Star").Length;
    }

    public void CheckScore()
    {
        if (scoreCount <= maxScore) return;

        if (sceneIndex >= totalScenes) {
            SceneManager.LoadScene(0);
            return;
        }
        

        SceneManager.LoadScene(sceneIndex + 1);
    }

    public void IncrementScore()
    {
        scoreCount++;
        scoreUI.UpdateScoreUI();
    }
}