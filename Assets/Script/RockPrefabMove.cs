﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockPrefabMove : MonoBehaviour
{
    int row;

    // Start is called before the first frame update
    void Start()
    {
        row = Random.Range(0, 3);
        switch (row)
        {
            case 0:
                transform.localScale = new Vector3(0.6f, 0.6f, 1);
                transform.position = new Vector3(12, -0.95f, 0);
                gameObject.GetComponent<Renderer>().sortingOrder = 31;
                break;
            case 1:
                transform.localScale = new Vector3(0.7f, 0.7f, 1);
                transform.position = new Vector3(12, -1.95f, 0);
                gameObject.GetComponent<Renderer>().sortingOrder = 32;
                break;
            case 2:
                transform.localScale = new Vector3(0.8f, 0.8f, 1);
                transform.position = new Vector3(12, -3.2f, 0);
                gameObject.GetComponent<Renderer>().sortingOrder = 33;
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0.1f, 0, 0);
    }
}
