using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryMove : MonoBehaviour
{
    int row;
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        row = Random.Range(0, 3);
        switch (row)
        {
            case 0:
                transform.localScale = new Vector3(5, 5, 1);
                transform.position = new Vector3(10, -0.95f, 0);
                gameObject.GetComponent<Renderer>().sortingOrder = 1;
                break;
            case 1:
                transform.localScale = new Vector3(6, 6, 1);
                transform.position = new Vector3(10, -1.95f, 0);
                gameObject.GetComponent<Renderer>().sortingOrder = 2;
                break;
            case 2:
                transform.localScale = new Vector3(7, 7, 1);
                transform.position = new Vector3(10, -3.2f, 0);
                gameObject.GetComponent<Renderer>().sortingOrder = 3;
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 stg = GameObject.Find("cherry").transform.position;
        transform.position -= new Vector3(0.1f, 0, 0);
        if (stg.x < -10)
        {
            obj.SetActive(false);
        }
    }
}
