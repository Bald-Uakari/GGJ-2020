using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseScript : MonoBehaviour
{
    // Start is called before the first frame update

    private int BaseHP;

    public int Score() 
    {
        return BaseHP;
    }

    void Awake()
    {
        BaseHP = 10;
    }

    void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 100, 25), "Farm Health: " + BaseHP);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetBaseToStart()
    {
        BaseHP = 0;
    }


    void OnTriggerEnter2D(Collider2D other){

         if (other.tag =="enemy") 
         {

            BaseHP -= 1;
            Debug.Log("current base HP, " +BaseHP+ " .");

         }
     }

}
