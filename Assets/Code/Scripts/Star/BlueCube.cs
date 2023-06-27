using UnityEngine;
using System.Collections;

public class BlueCube: BaseCube
{
    [SerializeField] private ToggleCamera toggleCamera;
    private float delay = 7.0f;

    protected override void ExecuteBehavior()
    {
        toggleCamera.toggleCam();
        if (delay < audioSource.clip.length)
        {
            delay = audioSource.clip.length;
        }
        StartCoroutine(DelayDestroy(delay));
    }

    protected override IEnumerator DelayDestroy(float delay)
    {
        yield return new WaitForSeconds(delay);
        toggleCamera.toggleCam();
        Destroy(gameObject);
    }
}