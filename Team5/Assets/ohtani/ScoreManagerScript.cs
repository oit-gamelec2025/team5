using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int totalScore = 0;

    public void AddScore(int amount)
    {
        totalScore += amount;
        Debug.Log("スコア加算: +" + amount + "点（合計: " + totalScore + "）");
    }
}