using UnityEngine;

public class CameraFollow : MonoBehaviour {
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset;
    private void FixedUpdate() {
        Vector3 camForward = transform.forward;
        camForward.y = 0;

        Vector3 targetPosition = target.position + new Vector3(0, offset.y, 0) + (camForward * offset.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, 0.5f);
    }
}