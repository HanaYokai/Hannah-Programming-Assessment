using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{


    public int speed = 5;
    private string targetMessage = "Hello World";
    public GameObject Target;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log(targetMessage);
        }

        //Distintion 1st part

        //target position += speed on the y

        //h,v,z
        //x,y,z

        //Target.transform.position += 

        //Distintion 2nd part
        /*
        if (target position y is odd)

        Debug.Log("Location: " + Target.transform.position);
        */
        //if(Target.position.y )


        /*
        for (int numberToPrint = 1; numberToPrint < (99 + 1); numberToPrint++)
        {
            if (numberToPrint % 2 != 0)
            {
                Debug.Log("location: " + numberToPrint);
            }
        }
        */

        //HD Homework 1
        //this is suppose to be for target? but its not attached to target?
        /*
        Vector3 direction = Vector3.zero;
        direction.x = Input.GetAxisRaw("Horizontal");
        Vector3.ClampMagnitude(direction, 1);
        transform.position += direction * speed * Time.deltaTime;
        */


    }

}
