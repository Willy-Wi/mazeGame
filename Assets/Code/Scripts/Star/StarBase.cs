using UnityEngine;

public class StarBase : MonoBehaviour
{
    [SerializeField] protected AudioSource audioSource;
    private BoxCollider bCollider;

    private void Awake()
    {
        bCollider = GetComponent<BoxCollider>();
    }

    protected void SharedBehavior()
    {
        audioSource.Play();
        // Destroys the Child of the GameObject that the script is attached to.
        // Also disables the Collider. 
        Destroy(transform.GetChild(0).gameObject);
        bCollider.enabled = false;
    }
}