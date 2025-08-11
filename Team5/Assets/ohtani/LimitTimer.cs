using UnityEngine;

public class LimitTimer : MonoBehaviour
{
    public float timeLimit = 60f; // 制限時間（秒）
    private float currentTime;

    void Start()
    {
        currentTime = timeLimit;
    }

    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            Debug.Log("残り時間: " + currentTime.ToString("F2") + "秒");
        }
        else
        {
            Debug.Log("時間切れ！");
            // ここに時間切れ時の処理を書く（例：ゲームオーバー）
            enabled = false; // 一度だけ表示するためにUpdateを止める
        }
    }
}