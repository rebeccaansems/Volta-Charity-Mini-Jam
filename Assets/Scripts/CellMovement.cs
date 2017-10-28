using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellMovement : MonoBehaviour
{
    public float initialSpeed = 5;

    private int points = 15;
    private float speed;

    void Start()
    {
        speed = initialSpeed;
    }

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

    void OnCollisionExit2D(Collision2D collision)
    {
        speed = initialSpeed;
    }
}
