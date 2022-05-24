using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GAMEMANAGER gamemanager;
    private void Start()
    {
        GameObject managerObject = GameObject.Find("GAMEMANAGER");
        gamemanager = managerObject.GetComponent<GAMEMANAGER>();
    }
    private void OnTriggerEnter(Collider other)
    {

         if (other.gameObject.tag == "Player")
            {
             gamemanager.AddcoinCount();
                Destroy(gameObject);
            }
        
    }
}
