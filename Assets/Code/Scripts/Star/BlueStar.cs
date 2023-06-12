using UnityEngine;
using System.Collections;

public class BlueStar : StarBase
{
    [SerializeField] private ToggleCamera toggleCamera;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // SharedBehavior() derived from StarBase class.
            SharedBehavior();
            toggleCamera.toggleCam();
            StartCoroutine(DestroyScheduled(7));
        }
    }

    // Wait for *delay amount seconds before switching back the camera.
    // After that, destroy the GameObject that script is attached to.
    private IEnumerator DestroyScheduled(float delay)
    {
        yield return new WaitForSeconds(delay);
        toggleCamera.toggleCam();
        Destroy(gameObject);
    }
}