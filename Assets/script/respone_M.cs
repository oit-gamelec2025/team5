using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respone_M : MonoBehaviour
{
    [SerializeField] private Vector3 spawnPosition1 = new Vector3(0, 1, 0);
    [SerializeField] private Vector3 spawnPosition2 = new Vector3(2, 1, 0);
    [SerializeField] private Vector3 spawnPosition3 = new Vector3(0, 1, 2);
    [SerializeField] private Vector3 spawnPosition4 = new Vector3(0, 1, 2);
    [SerializeField] private Vector3 spawnPosition5 = new Vector3(0, 1, 2);
    [SerializeField] private Vector3 spawnPosition6 = new Vector3(0, 1, 2);
    [SerializeField] private Vector3 spawnPosition7 = new Vector3(0, 1, 2);
    [SerializeField] private Vector3 spawnPosition8 = new Vector3(0, 1, 2);
    [SerializeField] private Vector3 spawnPosition9 = new Vector3(0, 1, 2);


    [SerializeField]
    [Tooltip("Random_hand")]
    private GameObject RH1Prefab;

    [SerializeField]
    [Tooltip("Random_hand")]
    private GameObject RH2Prefab;

    [SerializeField]
    [Tooltip("Random_hand")]
    private GameObject RH3Prefab;

    [SerializeField]
    [Tooltip("Random_hand")]
    private GameObject RH4Prefab;

    [SerializeField]
    [Tooltip("Random_hand")]
    private GameObject Item1Prefab;

    [SerializeField]
    [Tooltip("Item2")]
    private GameObject Item2Prefab;

    [SerializeField]
    [Tooltip("Item3")]
    private GameObject Item3Prefab;

    [SerializeField]
    [Tooltip("Item4")]
    private GameObject Item4Prefab;

    [SerializeField]
    [Tooltip("Item5")]
    private GameObject Item5Prefab;


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

        GameObject playerObj4 = GameObject.Find(RH4Prefab.name);
        if (playerObj4 == null)
        {
            GameObject newPlayerObj4 = Instantiate(RH4Prefab, spawnPosition6, Quaternion.identity);
            newPlayerObj4.name = RH4Prefab.name;
        }


        GameObject Item1 = GameObject.Find(Item1Prefab.name);
        if (Item1 == null)
        {
            GameObject newItem1 = Instantiate(Item1Prefab, spawnPosition4, Quaternion.identity);
            newItem1.name = Item1Prefab.name;
        }

        GameObject Item2 = GameObject.Find(Item2Prefab.name);
        if (Item2 == null)
        {
            GameObject newItem2 = Instantiate(Item2Prefab, spawnPosition5, Quaternion.identity);
            newItem2.name = Item2Prefab.name;
        }

        GameObject Item3 = GameObject.Find(Item3Prefab.name);
        if (Item3 == null)
        {
            GameObject newItem3 = Instantiate(Item3Prefab, spawnPosition7, Quaternion.identity);
            newItem3.name = Item3Prefab.name;
        }

        GameObject Item4 = GameObject.Find(Item4Prefab.name);
        if (Item4 == null)
        {
            GameObject newItem4 = Instantiate(Item4Prefab, spawnPosition8, Quaternion.identity);
            newItem4.name = Item4Prefab.name;
        }

        GameObject Item5 = GameObject.Find(Item5Prefab.name);
        if (Item5 == null)
        {
            GameObject newItem5 = Instantiate(Item5Prefab, spawnPosition9, Quaternion.identity);
            newItem5.name = Item5Prefab.name;
        }

    }

    void respone1()
    {

    }



}
