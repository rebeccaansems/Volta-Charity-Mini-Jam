using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellController : MonoBehaviour
{
    public bool isCure = true;
    public Color virusColor;

    private float cureTurnedTime = 0.1f, virusTurnedTime = 0.15f, turnTime = 0f;

    void Start()
    {
        this.GetComponent<SpriteRenderer>().color = Color.red;
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Cure" && !isCure)
        {
            turnTime += Time.deltaTime;
            if (turnTime > cureTurnedTime)
            {
                Convert(collision.gameObject.tag);
                turnTime = 0f;
            }
        }

        if (collision.gameObject.tag == "Virus" && isCure)
        {
            turnTime += Time.deltaTime;
            if (turnTime > virusTurnedTime)
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
            this.GetComponent<SpriteRenderer>().color = Color.red;
            isCure = true;
        }
        else if (convertType == "Virus")
        {
            this.GetComponent<SpriteRenderer>().color = virusColor;
            isCure = false;
        }
    }
}
