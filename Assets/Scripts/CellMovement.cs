using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellMovement : MonoBehaviour
{
    public float speed = 5;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(0.1f, 0.5f), 0);
        transform.position += move * speed * Time.deltaTime;
    }
}
