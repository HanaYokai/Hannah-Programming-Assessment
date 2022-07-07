using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int speed = 5;
    private int playerScore;
    public int addScore;
    
    
    void Start()
    {
        
    }

    
    void Update()
    {

        Vector3 direction = Vector3.zero;
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
        Vector3.ClampMagnitude(direction, 1);
        transform.position += direction * speed * Time.deltaTime;


    }

   private void Add(int addScore)
   {
       playerScore += addScore;
       printScore();
   }

   private void printScore()
   {
       Debug.Log(playerScore);
   }

   private void OnTriggerEnter2D(Collider2D collision)
   {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Add(5);
        }
    }
}
