using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Janken_Hand : MonoBehaviour
{
    public GameObject J1_object = null;
    public GameObject J2_object = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // オブジェクトからTextコンポーネントを取得
        Text score_text1 = J1_object.GetComponent<Text>();
        Text score_text2 = J2_object.GetComponent<Text>();

        int hand1 = Player1.hand1;
        int hand2 = Player2.hand2;

        if (hand1 == 1)
        {
            score_text1.text = "グー";
        }
        else if (hand1 == 2)
        {
            score_text1.text = "チョキ";
        }
        else if (hand1 == 3)
        {
            score_text1.text = "パー";
        }

        if (hand2 == 1)
        {
            score_text2.text = "グー";
        }
        else if (hand2 == 2)
        {
            score_text2.text = "チョキ";
        }
        else if (hand2 == 3)
        {
            score_text2.text = "パー";
        }
    }
}
