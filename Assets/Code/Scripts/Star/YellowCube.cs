using System.Collections;
using UnityEngine;

public class YellowCube : BaseCube
{
    [SerializeField] private ScoreManager score;
    protected override void ExecuteBehavior()
    {
        score.IncrementScore();
        StartCoroutine(DelayDestroy(audioSource.clip.length));
    }

    protected override IEnumerator DelayDestroy(float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);
    }
}