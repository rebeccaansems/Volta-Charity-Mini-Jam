using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 3.0f;
    public bool isCure;
    
    private float moveHorizontal, moveVertical;

    void FixedUpdate()
    {
        if (isCure)
        {
            moveHorizontal = Input.GetAxis("Horizontal_Cure");
            moveVertical = Input.GetAxis("Vertical_Cure");
        }
        else
        {
            if(this.transform.position.y > 0)
            {
                this.transform.position = new Vector2(this.transform.position.x, -2.1f);
            }

            moveHorizontal = Input.GetAxis("Horizontal_Virus");
            moveVertical = Input.GetAxis("Vertical_Virus");
        }

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        this.GetComponent<Rigidbody2D>().velocity = movement * speed;
    }
}
