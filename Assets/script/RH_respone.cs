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
            // playerPrefabから新しくGameObjectを作成
            GameObject newPlayerObj = Instantiate(playerPrefab);
            // 新しく作成したGameObjectの名前を再設定(今回は"PlayerSphere"となる)
            newPlayerObj.name = playerPrefab.name;
            // ※ここで名前を再設定しない場合、自動で決まる名前は、"PlayerSphere(Clone)"となるため
            //   13行目で探している"PlayerSphere"が永遠に見つからないことになり、playerが無限に生産される
            //   どういうことかは、22行目をコメントアウトしてゲームを実行すればわかります。
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
