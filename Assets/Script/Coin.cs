using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    


    void Start()
    {
        
    }

   
    void Update()
    {
      
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collision Detected");
            Destroy(gameObject);
        }
    }

}
