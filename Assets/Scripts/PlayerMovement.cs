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

    // Update is called once per frame
    void Update()
    {
        Vector3 move;
        if (isCure)
        {
            move = new Vector3(Input.GetAxis("Horizontal_Cure"), Input.GetAxis("Vertical_Cure"), 0);
        }
        else
        {
            move = new Vector3(Input.GetAxis("Horizontal_Virus"), Input.GetAxis("Vertical_Virus"), 0);
        }
        transform.position += move * speed * Time.deltaTime;
    }
}
