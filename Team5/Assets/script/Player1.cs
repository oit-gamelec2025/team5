using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{

    // UI画面のゲームオブジェクトを格納する変数
    // インスペクターウィンドウからゲームオブジェクトを設定する
    [SerializeField] GameObject logsView;

    // UI画面の表示状態を格納する変数
    public static bool isLogsView = true;



    public static int jan_S = 0;
    public static int hand1 = 0;
    float speed = 3.0f;
    public Vector3 posp1;
    public bool key = true;

    public static int getscore1()
    {

        return jan_S;
    }

    // Start is called before the first frame update
    void Start()
    {

    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Random_hand"))
        {
            hand1 = Random.Range(1,4);
            Destroy(collision.gameObject);

        }
            int hand2 = Player2.hand2;
        if (collision.gameObject.CompareTag("Player2"))
        {
            
            if (hand2 == 1 && hand1 == 1)
            {
                Debug.Log("あいこ");
            }
            else if (hand2 == 1 && hand1 == 2)
            {
                Debug.Log("負け");
                gameObject.transform.position = new Vector3(posp1.x, posp1.y, posp1.z);
                isLogsView = !isLogsView;
                logsView.SetActive(isLogsView);
                key = false;
                Invoke("EnableInput", 2f);

            }
            else if (hand2 == 1 && hand1 == 3)
            {
                Debug.Log("勝ち");
                jan_S = jan_S + 1;
            }
            else if (hand2 == 2 && hand1 == 1)
            {
                Debug.Log("勝ち");
                jan_S = jan_S + 1;
            }
            else if (hand2 == 2 && hand1 == 2)
            {
                Debug.Log("あいこ");
            }
            else if (hand2 == 2 && hand1 == 3)
            {
                Debug.Log("負け");
                gameObject.transform.position = new Vector3(posp1.x, posp1.y, posp1.z);
                isLogsView = !isLogsView;
                logsView.SetActive(isLogsView);
                key = false; 
                Invoke("EnableInput", 2f);
            }
            else if (hand2 == 3 && hand1 == 1)
            {
                Debug.Log("負け");
                gameObject.transform.position = new Vector3(posp1.x, posp1.y, posp1.z);
                isLogsView = !isLogsView;
                logsView.SetActive(isLogsView);
                key = false;
                Invoke("EnableInput", 2f);
            }
            else if (hand2 == 3 && hand1 == 2)
            {
                Debug.Log("勝ち");
                jan_S = jan_S + 1;
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
        if (key == true)
        {
            // Wキー（前方移動）
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += speed * transform.forward * Time.deltaTime;
            }

            // Sキー（後方移動）
            if (Input.GetKey(KeyCode.S))
            {
                transform.position -= speed * transform.forward * Time.deltaTime;
            }

            // Dキー（右移動）
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += speed * transform.right * Time.deltaTime;
            }

            // Aキー（左移動）
            if (Input.GetKey(KeyCode.A))
            {
                transform.position -= speed * transform.right * Time.deltaTime;
            }
        }


        if (Input.GetKey(KeyCode.G))
        {
            hand1 = 1;
            //グー
        }
        if (Input.GetKey(KeyCode.J))
        {
            hand1 = 2;
            //チョキ
        }
        if (Input.GetKey(KeyCode.H))
        {
            hand1 = 3;
            //パー
        }



    }


    // Settings Buttonが押されたときの処理
    public void G_Button()
    {
        hand1 = 1;
        isLogsView = !isLogsView;
        logsView.SetActive(isLogsView);
       
    }

    public void T_Button()
    {
        hand1 = 2;
        isLogsView = !isLogsView;
        logsView.SetActive(isLogsView);
        
    }

    public void P_Button()
    {
        hand1 = 3;
        isLogsView = !isLogsView;
        logsView.SetActive(isLogsView);

    }
    void EnableInput()
    {
        key = true;
    }
}
