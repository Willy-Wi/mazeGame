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
        Destroy(transform.GetChild(0).gameObject);
        bCollider.enabled = false;
    }
}