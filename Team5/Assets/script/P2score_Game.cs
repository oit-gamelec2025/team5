using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P2score_Game : MonoBehaviour
{
    public int score_num = 0;
    public GameObject score_object = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int jajan = Player2.jan_S;

        // �I�u�W�F�N�g����Text�R���|�[�l���g���擾
        Text score_text = score_object.GetComponent<Text>();
        // �e�L�X�g�̕\�������ւ���
        score_num = jajan;
        score_text.text = "Score:" + score_num; ;
    }
}
