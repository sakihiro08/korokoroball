using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GOAL2 : MonoBehaviour
{
    public GameObject next;
    public GameObject NEXTButton;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("Goal");
        next.SetActive(true);
        NEXTButton.SetActive(true);
        audioSource.Play();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
