using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respone_M : MonoBehaviour
{
    [SerializeField] private Vector3 spawnPosition1 = new Vector3(0, 1, 0);
    [SerializeField] private Vector3 spawnPosition2 = new Vector3(2, 1, 0);
    [SerializeField] private Vector3 spawnPosition3 = new Vector3(0, 1, 2);


    [SerializeField]
    [Tooltip("Random_hand")]
    private GameObject RH1Prefab;

    [SerializeField]
    [Tooltip("Random_hand")]
    private GameObject RH2Prefab;

    [SerializeField]
    [Tooltip("Random_hand")]
    private GameObject RH3Prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject playerObj = GameObject.Find(RH1Prefab.name);
        if (playerObj == null)
        {
            GameObject newPlayerObj = Instantiate(RH1Prefab,spawnPosition1, Quaternion.identity);
            newPlayerObj.name = RH1Prefab.name;
        }

        GameObject playerObj2 = GameObject.Find(RH2Prefab.name);
        if (playerObj2 == null)
        {
            GameObject newPlayerObj2 = Instantiate(RH2Prefab, spawnPosition2, Quaternion.identity);
            newPlayerObj2.name = RH2Prefab.name;
        }

        GameObject playerObj3 = GameObject.Find(RH3Prefab.name);
        if (playerObj3 == null)
        {
            GameObject newPlayerObj3 = Instantiate(RH3Prefab, spawnPosition3, Quaternion.identity);
            newPlayerObj3.name = RH3Prefab.name;
        }
    }

    void respone1()
    {

    }



}
