using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title_M : MonoBehaviour
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
             UnityEditor.EditorApplication.isPlaying = false;//?Q?[???v???C?I??
#else
            Application.Quit();//?Q?[???v???C?I??
#endif
        }
    }
    public void onClickStartButton()
    {
        SceneManager.LoadScene("Main", LoadSceneMode.Single);

    }
}
