using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellController : MonoBehaviour
{

    public int cellType = 0;

    private float turnedTime = 0.5f, turnTime = 0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Cure" || collision.gameObject.tag == "Virus")
        {
            turnTime += Time.deltaTime;
            if (turnTime > turnedTime)
            {
                Convert(collision.gameObject.tag);
                turnTime = 0f;
            }
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        turnTime = 0f;
    }

    void Convert(string convertType)
    {
        if(convertType == "Cure")
        {
            this.GetComponent<SpriteRenderer>().color = Color.yellow;
        }
        else if (convertType == "Virus")
        {
            this.GetComponent<SpriteRenderer>().color = Color.green;
        }
    }
}
