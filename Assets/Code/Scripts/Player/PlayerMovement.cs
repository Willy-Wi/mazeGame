using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Transform cam;
    private float speed = 7f;
    private Rigidbody rb;
    private Vector3 spawnPosition;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        spawnPosition = transform.position;
    }

    private void Update()
    {
        if (transform.position.y <= -10)
        {
            transform.position = spawnPosition + new Vector3(0, 1f, 0);
        }
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 camForward = cam.forward;
        Vector3 camRight = cam.right;

        camForward.y = 0;
        camRight.y = 0;

        Vector3 direction = ((horizontal * camRight) + (vertical * camForward)) * speed;

        // if input is given, then add velocity
        if (direction.magnitude >= 0.1f)
        {
            rb.velocity = direction;
        }

        // If no input is given, then stop the ball from continuously rotating
        if (Mathf.Approximately(horizontal, 0) && Mathf.Approximately(vertical, 0))
        {
            rb.angularVelocity = Vector3.zero;
        }
    }
}
