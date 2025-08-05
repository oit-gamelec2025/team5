using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respone_M : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Random_hand")]
    private GameObject RH1Prefab;

    [SerializeField]
    [Tooltip("Random_hand")]
    private GameObject RH2Prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject playerObj = GameObject.Find(RH1Prefab.name);
        // playerObj�����݂��Ă��Ȃ��ꍇ
        if (playerObj == null)
        {
            // playerPrefab����V����GameObject���쐬
            GameObject newPlayerObj = Instantiate(RH1Prefab);
            // �V�����쐬����GameObject�̖��O���Đݒ�(�����"PlayerSphere"�ƂȂ�)
            newPlayerObj.name = RH1Prefab.name;
            // �������Ŗ��O���Đݒ肵�Ȃ��ꍇ�A�����Ō��܂閼�O�́A"PlayerSphere(Clone)"�ƂȂ邽��
            //   13�s�ڂŒT���Ă���"PlayerSphere"���i���Ɍ�����Ȃ����ƂɂȂ�Aplayer�������ɐ��Y�����
            //   �ǂ��������Ƃ��́A22�s�ڂ��R�����g�A�E�g���ăQ�[�������s����΂킩��܂��B
        }

        GameObject playerObj2 = GameObject.Find(RH2Prefab.name);
        // playerObj�����݂��Ă��Ȃ��ꍇ
        if (playerObj2 == null)
        {
            // playerPrefab����V����GameObject���쐬
            GameObject newPlayerObj2 = Instantiate(RH2Prefab);
            // �V�����쐬����GameObject�̖��O���Đݒ�(�����"PlayerSphere"�ƂȂ�)
            newPlayerObj2.name = RH2Prefab.name;
            // �������Ŗ��O���Đݒ肵�Ȃ��ꍇ�A�����Ō��܂閼�O�́A"PlayerSphere(Clone)"�ƂȂ邽��
            //   13�s�ڂŒT���Ă���"PlayerSphere"���i���Ɍ�����Ȃ����ƂɂȂ�Aplayer�������ɐ��Y�����
            //   �ǂ��������Ƃ��́A22�s�ڂ��R�����g�A�E�g���ăQ�[�������s����΂킩��܂��B
        }
    }
}
