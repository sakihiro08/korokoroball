using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GOAL : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="GOAL")
        {
            Debug.Log("Goal");
        }
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
