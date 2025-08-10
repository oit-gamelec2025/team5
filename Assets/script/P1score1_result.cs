using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P1score1_result : MonoBehaviour
{
    public Text ScoreText;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        score = Player1.getscore1();

        ScoreText.text = string.Format("Score:{0}", score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
