using System.Collections;
using UnityEngine;

public class YellowStar : StarBase
{
    private GameObject[] yellowStars;
    [SerializeField] private Score score;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SharedBehavior();
            score.UpdateScore();
            StartCoroutine(DestroyScheduled(audioSource.clip.length));
        }
    }

    private IEnumerator DestroyScheduled(float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);
    }
}