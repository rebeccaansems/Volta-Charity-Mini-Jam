using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusAI : MonoBehaviour
{
    private float speed;
    private float moveHorizontal, moveVertical;
    private float time = 5;

    void Start()
    {
        speed = GetComponent<PlayerMovement>().speed;
    }

    void FixedUpdate()
    {
        if (GameStats.singlePlayerMode)
        {
            if (this.transform.position.y > 0)
            {
                this.transform.position = new Vector2(this.transform.position.x, -2.1f);
            }

            if (GameStats.singlePlayerMode && this.GetComponent<PlayerMovement>() != null)
            {
                Destroy(this.GetComponent<PlayerMovement>());
            }

            if (time > 3f)
            {
                time = 0f;
                moveHorizontal = Random.Range(-1f, 1f);
                moveVertical = Random.Range(-1f, 1f);
            }

            time += Time.deltaTime;
            Vector2 movement = new Vector2(moveHorizontal, moveVertical);
            this.GetComponent<Rigidbody2D>().velocity = movement * speed;
        }
    }
}
