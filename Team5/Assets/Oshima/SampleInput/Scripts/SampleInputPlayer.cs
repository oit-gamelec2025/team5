using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace SampleInput
{
    ///
    /// InputSystem - PlayerInput入力テスト用プレイヤークラス
    /// 
    public class SampleInputPlayer : MonoBehaviour
    {
        // プレイヤーインデックス
        public enum PlayerIndex
        {
            P1 = 0, // 1プレイヤー
            P2 = 1  // 2プレイヤー
        }


        [Header("プレイヤー番号"), SerializeField] private PlayerIndex _index = PlayerIndex.P1;
        [Header("移動速度"), SerializeField] private float _moveSpeed = 3.0f;
        [Header("入力"), SerializeField] private PlayerInput _playerInput;
        private Vector3 _velocity; // 移動値
        private string _playerName;

        void Start()
        {
            // 1.接続されている全てのコントローラ取得
            var gamepads = Gamepad.all;

            // 2.自身のインデックス(プレイヤー1なら0, プレイヤー2なら1)に対応したコントローラが接続されているかチェック
            var index = (int)_index;
            if (gamepads.Count <= index)
            {
                Debug.LogWarning($"プレイヤーに割り当てるゲームコントローラが見つかりません {index}");
                return;
            }

            // 3.接続されているコントローラーをプレイヤー入力へ割り当てて使用する
            _playerInput.SwitchCurrentControlScheme(gamepads[index]);

            _playerName = gameObject.name;       
        }

        /// <summary>
        /// PlayerInputへ登録したActionMapに対応した入力イベント OnXXXXXX の形式で受け取ります
        /// </summary>
        /// <param name="value">コントローラースティックの入力量</param>
        private void OnMove(InputValue value)
        {
            // XY方向へ変換
            var axis = value.Get<Vector2>();

            // 移動速度を保持
            _velocity = new Vector3(axis.x, 0, axis.y);
        }

        private void Update()
        {
            // 入力された値で移動オブジェクト移動
            transform.position += _velocity * _moveSpeed * Time.deltaTime;
        }

        ///
        /// for debug. 入力値を画面出力
        /// 
        void OnGUI()
        {
            GUIStyle style = new GUIStyle(GUI.skin.label);
            style.fontSize = 20;
            style.normal.textColor = Color.red;

            GUI.Label(new Rect(10, Screen.height - 100 - 30 * (int)_index, 500, 30),$"{_playerName} - Move: {_velocity},", style);
        }

    }
}