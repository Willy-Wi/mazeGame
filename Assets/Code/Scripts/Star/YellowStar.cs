using System.Collections;
using UnityEngine;

public class YellowStar : StarBase
{
    [SerializeField] private Score score;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // SharedBehavior() derived from StarBase class.
            SharedBehavior();
            score.UpdateScore();
            StartCoroutine(DestroyScheduled(audioSource.clip.length));
        }
    }

    // Wait for *delay amount seconds before destroying the GameObject that script is attached to.
    private IEnumerator DestroyScheduled(float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);
    }
}