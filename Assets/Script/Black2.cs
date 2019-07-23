using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Black2 : MonoBehaviour
{
    Vector3 blk;
    float val = 0.0000001f, val2 = 1.00001f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        blk = transform.position;
        blk = transform.position;
        transform.position -= new Vector3(val, 0, 0);
        val += 0.001f * (val2 = val2 * 1.3f);
        if (blk.x < -20.0f)
        {
            gameObject.SetActive(false);
        }
    }
}
