using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicRockMove : MonoBehaviour
{
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = gameObject.transform.position;
        switch (pos.y)
        {
            case -0.95f:
                transform.localScale = new Vector3(0.6f, 0.6f, 1);
                gameObject.GetComponent<Renderer>().sortingOrder = 31;
                break;
            case -1.95f:
                transform.localScale = new Vector3(0.7f, 0.7f, 1);
                gameObject.GetComponent<Renderer>().sortingOrder = 32;
                break;
            case -3.2f:
                transform.localScale = new Vector3(0.8f, 0.8f, 1);
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
