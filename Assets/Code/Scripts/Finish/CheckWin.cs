using UnityEngine;

public class CheckWin : MonoBehaviour
{
    [SerializeField] private Score score;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            score.CheckScore();
        }
    }
}