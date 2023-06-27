using UnityEngine;
using System.Collections;

public abstract class BaseStar: MonoBehaviour
{
    [SerializeField] protected AudioSource audioSource;
    private BoxCollider bCollider;
    private void Awake() {
        bCollider = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioSource.Play();
            Destroy(transform.GetChild(0).gameObject);
            bCollider.enabled = false;
            ExecuteBehavior();
        }
    }

    protected abstract void ExecuteBehavior();

    protected abstract IEnumerator DelayDestroy(float delay);
}