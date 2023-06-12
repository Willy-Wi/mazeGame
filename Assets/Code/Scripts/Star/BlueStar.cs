using UnityEngine;
using System.Collections;

public class BlueStar : StarBase
{
    [SerializeField] private ToggleCamera toggleCamera;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SharedBehavior();
            toggleCamera.toggleCam();
            StartCoroutine(DestroyScheduled(7));
        }
    }

    private IEnumerator DestroyScheduled(float delay)
    {
        yield return new WaitForSeconds(delay);
        toggleCamera.toggleCam();
        Destroy(gameObject);
    }
}