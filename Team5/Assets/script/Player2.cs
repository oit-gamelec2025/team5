using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{


    // UI��ʂ̃Q�[���I�u�W�F�N�g���i�[����ϐ�
    // �C���X�y�N�^�[�E�B���h�E����Q�[���I�u�W�F�N�g��ݒ肷��
    [SerializeField] GameObject logsView;

    // UI��ʂ̕\����Ԃ��i�[����ϐ�
    public static bool isLogsView = true;


    public static int jan_S = 0;
    public static int hand2;
    float speed = 3.0f;
    public Vector3 posp2;
    public bool key = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public static int getscore2()
    {

        return jan_S;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Random_hand"))
        {
            hand2 = Random.Range(1, 4);
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Player1"))
        {
   
            int hand1 = Player1.hand1;
            if (hand2 == 1 && hand1 == 1)
            {
                Debug.Log("������");
            }
            else if (hand2 == 1 && hand1 == 2)
            {
                Debug.Log("����");
                jan_S = jan_S + 1;
            }
            else if (hand2 == 1 && hand1 == 3)
            {
                Debug.Log("����");
                gameObject.transform.position = new Vector3(posp2.x, posp2.y, posp2.z);
                isLogsView = !isLogsView;
                logsView.SetActive(isLogsView);
                key = false;
                Invoke("EnableInput", 2f);
            }
            else if (hand2 == 2 && hand1 == 1)
            {
                Debug.Log("����");
                gameObject.transform.position = new Vector3(posp2.x, posp2.y, posp2.z);
                isLogsView = !isLogsView;
                logsView.SetActive(isLogsView);
                key = false;
                Invoke("EnableInput", 2f);
            }
            else if (hand2 == 2 && hand1 == 2)
            {
                Debug.Log("������");
            }
            else if (hand2 == 2 && hand1 == 3)
            {
                Debug.Log("����");
                jan_S = jan_S + 1;
            }
            else if (hand2 == 3 && hand1 == 1)
            {
                Debug.Log("����");
                jan_S = jan_S + 1;
            }
            else if (hand2 == 3 && hand1 == 2)
            {
                Debug.Log("����");
                gameObject.transform.position = new Vector3(posp2.x, posp2.y, posp2.z);
                isLogsView = !isLogsView;
                logsView.SetActive(isLogsView);
                key = false;
                Invoke("EnableInput", 2f);
            }
            else if (hand2 == 3 && hand1 == 3)
            {
                Debug.Log("������");
            }

        }

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.T))
        {
            hand2 = 1;
            //�O�[
        }
        if (Input.GetKey(KeyCode.Y))
        {
            hand2 = 2;
            //�`���L
        }
        if (Input.GetKey(KeyCode.U))
        {
            hand2 = 3;
            //�p�[
        }

        if (key == true)
        {
            // @�L�[�i�O���ړ��j
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position += speed * transform.forward * Time.deltaTime;
            }

            // S�L�[�i����ړ��j
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.position -= speed * transform.forward * Time.deltaTime;
            }

            // D�L�[�i�E�ړ��j
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += speed * transform.right * Time.deltaTime;
            }

            // A�L�[�i���ړ��j
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position -= speed * transform.right * Time.deltaTime;
            }
        }

    }

    public void G_Button()
    {
        hand2 = 1;
        isLogsView = !isLogsView;
        logsView.SetActive(isLogsView);
    }

    public void T_Button()
    {
        hand2 = 2;
        isLogsView = !isLogsView;
        logsView.SetActive(isLogsView);
    }

    public void P_Button()
    {
        hand2 = 3;
        isLogsView = !isLogsView;
        logsView.SetActive(isLogsView);
    }
    void EnableInput()
    {
        key = true;
    }

}
