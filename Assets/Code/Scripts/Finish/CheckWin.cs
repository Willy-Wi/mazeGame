using UnityEngine;

public class CheckWin : MonoBehaviour
{
    [SerializeField] private ScoreManager score;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            score.CheckScore();
        }
    }
}