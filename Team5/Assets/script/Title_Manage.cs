using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Title_Manage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            SceneManager.LoadScene("Main", LoadSceneMode.Single);
        }
        if (Input.GetButton("Fire2"))
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;//ゲームプレイ終了
#else
            Application.Quit();//ゲームプレイ終了
#endif
        }
    }
    public void onClickStartButton()
    {
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }
    

}
