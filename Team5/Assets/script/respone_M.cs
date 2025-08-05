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
        // playerObjが存在していない場合
        if (playerObj == null)
        {
            // playerPrefabから新しくGameObjectを作成
            GameObject newPlayerObj = Instantiate(RH1Prefab);
            // 新しく作成したGameObjectの名前を再設定(今回は"PlayerSphere"となる)
            newPlayerObj.name = RH1Prefab.name;
            // ※ここで名前を再設定しない場合、自動で決まる名前は、"PlayerSphere(Clone)"となるため
            //   13行目で探している"PlayerSphere"が永遠に見つからないことになり、playerが無限に生産される
            //   どういうことかは、22行目をコメントアウトしてゲームを実行すればわかります。
        }

        GameObject playerObj2 = GameObject.Find(RH2Prefab.name);
        // playerObjが存在していない場合
        if (playerObj2 == null)
        {
            // playerPrefabから新しくGameObjectを作成
            GameObject newPlayerObj2 = Instantiate(RH2Prefab);
            // 新しく作成したGameObjectの名前を再設定(今回は"PlayerSphere"となる)
            newPlayerObj2.name = RH2Prefab.name;
            // ※ここで名前を再設定しない場合、自動で決まる名前は、"PlayerSphere(Clone)"となるため
            //   13行目で探している"PlayerSphere"が永遠に見つからないことになり、playerが無限に生産される
            //   どういうことかは、22行目をコメントアウトしてゲームを実行すればわかります。
        }
    }
}
