using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RH_resupone : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Random_hand")]
    private GameObject playerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject playerObj = GameObject.Find(playerPrefab.name);
        if (playerObj == null)
        {
            // playerPrefab����V����GameObject���쐬
            GameObject newPlayerObj = Instantiate(playerPrefab);
            // �V�����쐬����GameObject�̖��O���Đݒ�(�����"PlayerSphere"�ƂȂ�)
            newPlayerObj.name = playerPrefab.name;
            // �������Ŗ��O���Đݒ肵�Ȃ��ꍇ�A�����Ō��܂閼�O�́A"PlayerSphere(Clone)"�ƂȂ邽��
            //   13�s�ڂŒT���Ă���"PlayerSphere"���i���Ɍ�����Ȃ����ƂɂȂ�Aplayer�������ɐ��Y�����
            //   �ǂ��������Ƃ��́A22�s�ڂ��R�����g�A�E�g���ăQ�[�������s����΂킩��܂��B
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player1") || collision.gameObject.CompareTag("Player2"))
        {
           Destroy(gameObject);
            Invoke(nameof(respone), 5.0f);
        }
    }
    void respone()
    {

    }


}
