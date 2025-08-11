using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class Siten : MonoBehaviour
{
    Vector2 move;
    Vector2 look;
    public float moveSpeed = 5f, turnSpeed = 120f;
    public Transform cameraPivot; // カメラの親（首の位置など）
    public float pitchLimit = 80f; // 上下の視点制限

    float pitch = 0f; // 現在の上下角度

    public void OnMove(InputAction.CallbackContext ctx)
    {
        if (ctx.performed) move = ctx.ReadValue<Vector2>();
        else if (ctx.canceled) move = Vector2.zero;
    }

    public void OnLook(InputAction.CallbackContext ctx)
    {
        if (ctx.performed) look = ctx.ReadValue<Vector2>();
        else if (ctx.canceled) look = Vector2.zero;
    }

    public void OnJump(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            Debug.Log("Jump!");
            // ジャンプ処理があるならここ
        }
    }

    void Update()
    {
        // 移動
        var dir = new Vector3(move.x, 0, move.y);
        transform.Translate(dir * moveSpeed * Time.deltaTime, Space.Self);

        // 左右回転（ヨー）
        transform.Rotate(Vector3.up, look.x * turnSpeed * Time.deltaTime);

        // 上下回転（ピッチ）
        if (cameraPivot != null)
        {
            pitch -= look.y * turnSpeed * Time.deltaTime;
            pitch = Mathf.Clamp(pitch, -pitchLimit, pitchLimit);
            cameraPivot.localRotation = Quaternion.Euler(pitch, 0, 0);
        }
    }

    void Awake()
    {
        var pi = GetComponent<PlayerInput>();
        if (pi.currentActionMap == null || pi.currentActionMap.name != "Player")
            pi.SwitchCurrentActionMap("Player");
    }
}