using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    [SerializeField] private Transform player; // �v���C���[��Transform
    [SerializeField] private Transform followergu; // �Ǐ]���������I�u�W�F�N�g
    [SerializeField] private Vector3 offset = new Vector3(0, 3, 0); // �v���C���[����̑��Έʒu
    [SerializeField] private Transform followerpa;
    [SerializeField] private Transform followertyoki;

    public Vector3 paPosition;
    public Vector3 guPosition;
    public Vector3 tyok1Position;
    public Vector3 player2Position;
    [SerializeField]
    [Tooltip("Player2")]
    private GameObject player2;

    [SerializeField]
    [Tooltip("pa-")]
    private GameObject pa;
    [SerializeField]
    [Tooltip("gu-")]
    private GameObject gu;
    [SerializeField]
    [Tooltip("tyoki")]
    private GameObject tyoki;



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
    public int up = 0;
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

        if (collision.gameObject.CompareTag("Item1"))
        {
            Destroy(collision.gameObject);
            speed = 10.0f;
            Invoke("Statas", 10);
        }
        if (collision.gameObject.CompareTag("item3"))
        {
            Destroy(collision.gameObject);
            up = 1;
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
                if(up == 0)
                {
                    jan_S = jan_S + 1;
                }
                else 
                {
                    jan_S = jan_S + 3;
                    up = 0;
                }
                
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
                if (up == 0)
                {
                    jan_S = jan_S + 1;
                }
                else
                {
                    jan_S = jan_S + 3;
                    up = 0;
                }
            }
            else if (hand2 == 3 && hand1 == 1)
            {
                Debug.Log("����");
                if (up == 0)
                {
                    jan_S = jan_S + 1;
                }
                else
                {
                    jan_S = jan_S + 3;
                    up = 0;
                }
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
        player2Position = player2.transform.position;

        paPosition = player2Position;
        guPosition = player2Position;
        tyok1Position = player2Position;

        followergu.position = player.position + offset;
        followerpa.position = player.position + offset;
        followertyoki.position = player.position + offset;
        if (hand2 == 1)
        {
            pa.SetActive(false);
            gu.SetActive(true);
            tyoki.SetActive(false);
        }
        else if (hand2 == 2)
        {
            pa.SetActive(false);
            gu.SetActive(false);
            tyoki.SetActive(true);

        }
        else if (hand2 == 3)
        {
            pa.SetActive(true);
            gu.SetActive(false);
            tyoki.SetActive(false);
        }



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

    public void Statas() 
    {
        speed = 3.0f;
    }

    void EnableInput()
    {
        key = true;
    }

}
