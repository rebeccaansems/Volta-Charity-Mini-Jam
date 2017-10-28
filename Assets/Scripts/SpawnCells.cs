using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCells : MonoBehaviour
{

    public GameObject cell;

    void Update()
    {
        if(transform.childCount < 100)
        {
            GameObject newCell = Instantiate(cell, new Vector3(Random.Range(-7f, 7f), Random.Range(-5.5f, -15f), 0), new Quaternion(0,0,0,0));
            newCell.transform.parent = this.transform;
            newCell.GetComponent<CellMovement>().initialSpeed = Random.Range(2f, 8f);
        }
    }
}
