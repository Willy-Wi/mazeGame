using UnityEngine;
using UnityEngine.SceneManagement;
public class Score : MonoBehaviour
{
    private int yellowStarsCount;
    private int scoreCount;
    private int sceneIndex;
    private int totalScenes;
    [SerializeField] ScoreUI scoreUI;

    private void Awake()
    {
        yellowStarsCount = GameObject.FindGameObjectsWithTag("Yellow Star").Length;
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        totalScenes = SceneManager.sceneCountInBuildSettings;
    }

    public int GetScore()
    {
        return scoreCount;
    }

    public int GetMaxScore()
    {
        return yellowStarsCount;
    }

    public void CheckScore()
    {
        if (scoreCount >= yellowStarsCount)
        {
            if (sceneIndex >= totalScenes)
            {
                SceneManager.LoadScene(0);
                return;
            }
            SceneManager.LoadScene(sceneIndex + 1);
        }
    }

    public void UpdateScore()
    {
        scoreCount++;
        scoreUI.UpdateScoreUI();
    }
}