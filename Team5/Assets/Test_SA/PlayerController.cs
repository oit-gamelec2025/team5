using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class PlayerController : MonoBehaviour
{
    Vector2 move;
    Vector2 look;
    public float moveSpeed = 5f, turnSpeed = 120f;

    // Unity Events では CallbackContext を受け取る
    public void OnMove(InputAction.CallbackContext ctx)
    {
        // started/performed/canceled 全部飛んでくるので、canceledで0に戻す
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
        // シンプル移動
        var dir = new Vector3(move.x, 0, move.y);
        transform.Translate(dir * moveSpeed * Time.deltaTime, Space.Self);
        transform.Rotate(Vector3.up, look.x * turnSpeed * Time.deltaTime);
    }

    void Awake()
    {
        var pi = GetComponent<PlayerInput>();
        if (pi.currentActionMap == null || pi.currentActionMap.name != "Player")
            pi.SwitchCurrentActionMap("Player");
    }

}
