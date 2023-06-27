using System.Collections;
using UnityEngine;

public class YellowCube : BaseCube
{
    [SerializeField] private Score score;
    protected override void ExecuteBehavior()
    {
        score.UpdateScore();
        StartCoroutine(DelayDestroy(audioSource.clip.length));
    }

    protected override IEnumerator DelayDestroy(float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);
    }
}