using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;

public class GamepadAssigner : MonoBehaviour
{
    [SerializeField] List<PlayerInput> players;

    void OnEnable()
    {
        InputSystem.onDeviceChange += OnDeviceChange;
        ReassignAll();
    }

    void OnDisable()
    {
        InputSystem.onDeviceChange -= OnDeviceChange;
    }

    void OnDeviceChange(InputDevice dev, InputDeviceChange change)
    {
        if (dev is Gamepad && (
            change == InputDeviceChange.Added ||
            change == InputDeviceChange.Removed ||
            change == InputDeviceChange.Disconnected ||
            change == InputDeviceChange.Reconnected))
        {
            ReassignAll();
        }
    }

    void ReassignAll()
    {
        var pads = Gamepad.all;

        // まず全員のペアリング解除＋オートスイッチ無効
        foreach (var p in players)
        {
            p.neverAutoSwitchControlSchemes = true;
            p.user.UnpairDevices(); // ← これだけでOK（nullを渡すPerformPairingは不要）
        }

        for (int i = 0; i < players.Count; i++)
        {
            var p = players[i];

            if (i < pads.Count)
            {
                var pad = pads[i];
                // デバイスをユーザーにペアリング
                InputUser.PerformPairingWithDevice(pad, p.user);

                // Control Scheme が "Gamepad" の場合は名前＋デバイス指定が確実
                p.SwitchCurrentControlScheme("Gamepad", pad);

                Debug.Log($"Player {i} ← {pad.displayName} を割り当て");
                SetPlayable(p, true);
            }
            else
            {
                Debug.LogWarning($"Player {i} に割り当て可能な Gamepad が不足");
                SetPlayable(p, false);
            }
        }
    }

    void SetPlayable(PlayerInput p, bool on)
    {
        // 必要ならここで移動スクリプトやカメラ、UIを有効/無効化
        // GetComponent<YourController>().enabled = on; など
    }
}
