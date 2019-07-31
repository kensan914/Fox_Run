using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitlePlayerMove : MonoBehaviour
{
    bool rightDirection = true;
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-7.5f, -3.2f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        pos = gameObject.transform.position;
        if (rightDirection)
        {
            transform.localScale = new Vector3(13.0f, 13.0f, 1);
            transform.position += new Vector3(0.05f, 0, 0);
            if (pos.x > 7.5) rightDirection = false;
        }
        else
        {
            transform.localScale = new Vector3(-13.0f, 13.0f, 1);
            transform.position -= new Vector3(0.05f, 0, 0);
            if (pos.x < -7.5) rightDirection = true;
        }
    }
}
