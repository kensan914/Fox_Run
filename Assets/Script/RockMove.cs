using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockMove : MonoBehaviour
{
    int row;
    public GameObject obj;
    GameObject rockObj;
    // Start is called before the first frame update
    void Start()
    {
        rockObj = GameObject.Find("rock");
        row = Random.Range(0, 3);
        switch (row)
        {
            case 0:
                transform.localScale = new Vector3(0.6f, 0.6f, 1);
                transform.position = new Vector3(10, -0.95f, 0);
                gameObject.GetComponent<Renderer>().sortingOrder = 31;
                break;
            case 1:
                transform.localScale = new Vector3(0.7f, 0.7f, 1);
                transform.position = new Vector3(10, -1.95f, 0);
                gameObject.GetComponent<Renderer>().sortingOrder = 32;
                break;
            case 2:
                transform.localScale = new Vector3(0.8f, 0.8f, 1);
                transform.position = new Vector3(10, -3.2f, 0);
                gameObject.GetComponent<Renderer>().sortingOrder = 33;
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 stg = rockObj.transform.position;
        transform.position -= new Vector3(0.1f, 0, 0);
        if (stg.x < -15)
        {
            obj.SetActive(false);
        }
    }
}
