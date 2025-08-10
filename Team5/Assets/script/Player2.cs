using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    [SerializeField] private Transform player; // プレイヤーのTransform
    [SerializeField] private Transform followergu; // 追従させたいオブジェクト
    [SerializeField] private Vector3 offset = new Vector3(0, 3, 0); // プレイヤーからの相対位置
    [SerializeField] private Transform followerpa;
    [SerializeField] private Transform followertyoki;
    [SerializeField] private Transform cameraTransform; // メインカメラのTransform


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


    // UI画面のゲームオブジェクトを格納する変数
    // インスペクターウィンドウからゲームオブジェクトを設定する
    [SerializeField] GameObject logsView;

    // UI画面の表示状態を格納する変数
    public static bool isLogsView = true;


    public static int jan_S = 0;
    public static int hand2;
    float speed = 3.0f;
    public Vector3 posp2;
    public bool key = true;
    public int up = 0;
    public int n = 0;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        jan_S = 0;
        //animator = GetComponent<Animator>();
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
                Debug.Log("あいこ");
            }
            else if (hand2 == 1 && hand1 == 2)
            {
                Debug.Log("勝ち");
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
            else if (hand2 == 1 && hand1 == 3)
            {
                Debug.Log("負け");
                gameObject.transform.position = new Vector3(posp2.x, posp2.y, posp2.z);
                isLogsView = !isLogsView;
                logsView.SetActive(isLogsView);
                key = false;
                Invoke("EnableInput", 2f);
                hand2 = 0;
                n = 0;
            }
            else if (hand2 == 2 && hand1 == 1)
            {
                Debug.Log("負け");
                gameObject.transform.position = new Vector3(posp2.x, posp2.y, posp2.z);
                isLogsView = !isLogsView;
                logsView.SetActive(isLogsView);
                key = false;
                Invoke("EnableInput", 2f);
                hand2 = 0;
                n= 0;
            }
            else if (hand2 == 2 && hand1 == 2)
            {
                Debug.Log("あいこ");
            }
            else if (hand2 == 2 && hand1 == 3)
            {
                Debug.Log("勝ち");
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
                Debug.Log("勝ち");
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
                Debug.Log("負け");
                gameObject.transform.position = new Vector3(posp2.x, posp2.y, posp2.z);
                isLogsView = !isLogsView;
                logsView.SetActive(isLogsView);
                key = false;
                Invoke("EnableInput", 2f);
                hand2 = 0;
                n = 0;
            }
            else if (hand2 == 3 && hand1 == 3)
            {
                Debug.Log("あいこ");
            }

        }

    }

    // Update is called once per frame
    void Update()
    {
        // カメラの向きから水平回転だけ取得
        Vector3 camForward = cameraTransform.forward;
        camForward.y = 0; // 上下方向は無視
        camForward.Normalize();

        // プレイヤーの向きをカメラと合わせる
        if (camForward.sqrMagnitude > 0.001f)
        {
            transform.rotation = Quaternion.LookRotation(camForward);
        }
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
            //グー
        }
        if (Input.GetKey(KeyCode.Y))
        {
            hand2 = 2;
            //チョキ
        }
        if (Input.GetKey(KeyCode.U))
        {
            hand2 = 3;
            //パー
        }

        if (key == true)
        {
            // @キー（前方移動）
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position += speed * transform.forward * Time.deltaTime;
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                animator.SetBool("walk", !animator.GetBool("walk"));
            }
            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                animator.SetBool("walk", !animator.GetBool("walk"));
            }


            // Sキー（後方移動）
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.position -= speed * transform.forward * Time.deltaTime;
            }

            // Dキー（右移動）
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += speed * transform.right * Time.deltaTime;
            }

            // Aキー（左移動）
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position -= speed * transform.right * Time.deltaTime;
            }
        }
        var up_P2 = Input.GetAxis("up_P2");
        var down_P2 = Input.GetAxis("down_P2");
        var left_P2 = Input.GetAxis("left_P2");
        if (n == 0)
        {
            if(up_P2 > 0)
            {
                hand2 = 1;
                isLogsView = !isLogsView;
                logsView.SetActive(isLogsView);
                n = 1;
            }
            if(down_P2 < 0)
            {
                hand2 = 3;
                isLogsView = !isLogsView;
                logsView.SetActive(isLogsView);
                n = 1;
            }
            if (left_P2 < 0) 
            {
                hand2 = 2;
                isLogsView = !isLogsView;
                logsView.SetActive(isLogsView);
                n = 1;
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
