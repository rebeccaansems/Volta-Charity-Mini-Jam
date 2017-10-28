using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellMovement : MonoBehaviour
{
    public float initialSpeed = 5;

    private int points = 10;
    private float speed;

    // Use this for initialization
    void Start()
    {
        speed = initialSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(0.1f, 0.5f), 0);
        transform.position += move * speed * Time.deltaTime;

        if (transform.position.y > 6)
        {
            if (this.GetComponent<CellController>().isCure)
            {
                GameStats.curedCells++;
            }
            else
            {
                GameStats.virusCells += points;
            }
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Cure" || collision.gameObject.tag == "Virus")
        {
            //speed = 0.1f;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        speed = initialSpeed;
    }
}
