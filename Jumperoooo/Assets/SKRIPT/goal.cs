using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private bool WinScreen = true;

    private void Reset()
    {
        GetComponent<BoxCollider2D>().isTrigger = true;
        WinScreen = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            Debug.Log("YOU WIN");
            WinScreen = true;  
        }
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}