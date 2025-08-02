using UnityEngine;
using UnityEngine.InputSystem;

public class BallMover : MonoBehaviour
{
    [SerializeField] private float jumpForce = 5.0f;
    private Rigidbody rb;
    private MyControls controls;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        controls = new MyControls();

        // Jumpアクションにイベントを登録
        controls.player1.jump.performed += OnJumpPerformed;
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    private void OnJumpPerformed(InputAction.CallbackContext context)
    {
        if (rb != null)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}