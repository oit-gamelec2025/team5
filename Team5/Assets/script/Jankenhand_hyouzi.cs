using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jankenhand_hyouzi : MonoBehaviour
{
    public Vector3 player1Position;
    public Vector3 player2Position;



    [SerializeField]
    [Tooltip("pa-")]
    private GameObject pa;
    [SerializeField]
    [Tooltip("gu-")]
    private GameObject gu;
    [SerializeField]
    [Tooltip("tyoki")]
    private GameObject tyoki;

    [SerializeField]
    [Tooltip("pa-2")]
    private GameObject pa2;
    [SerializeField]
    [Tooltip("gu-2")]
    private GameObject gu2;
    [SerializeField]
    [Tooltip("tyoki2")]
    private GameObject tyoki2;
 



    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
      int hand1 = Player1.hand1;
      int hand2 = Player2.hand2;

      
 
      if (hand1 == 1)   
      {
            pa.SetActive(false);
            gu.SetActive(true);
            tyoki.SetActive(false);
      }
      else if(hand1 == 2)
      {
            pa.SetActive(false);
            gu.SetActive(false);
            tyoki.SetActive(true);

        }
      else if(hand1 == 3)
      {
            pa.SetActive(true);
            gu.SetActive(false);
            tyoki.SetActive(false);
        }

  
    }
}
