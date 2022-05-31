using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public GAMEMANAGER gamemanager;
    public AudioSource audioSource;
    private void Start()
    {
        GameObject managerObject = GameObject.Find("GAMEMANAGER");
        gamemanager = managerObject.GetComponent<GAMEMANAGER>();
    }
    private void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
        if (other.gameObject.tag == "Player")
        {
            gamemanager.AddcoinCount();
            Destroy(gameObject);

        }

    }
}