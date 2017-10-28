using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 3.0f;
    public bool isCure;

    // Use this for initialization
    void Start()
    {

    }
    float moveHorizontal, moveVertical;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isCure)
        {
            moveHorizontal = Input.GetAxis("Horizontal_Cure");
            moveVertical = Input.GetAxis("Vertical_Cure");
        }
        else
        {
            moveHorizontal = Input.GetAxis("Horizontal_Virus");
            moveVertical = Input.GetAxis("Vertical_Virus");
        }
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        this.GetComponent<Rigidbody2D>().velocity = movement * speed;
    }
}
