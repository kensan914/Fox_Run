using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StagePrefab : MonoBehaviour
{
    public GameObject obj;
    bool isCalled = false;
    public float speed, posPreX, poxPreY;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 stgP = obj.transform.position;
        transform.position -= new Vector3(speed, 0, 0);
        if (stgP.x < 0 && isCalled == false)
        {
            Instantiate(obj.gameObject, new Vector3(posPreX, poxPreY, 0), Quaternion.identity);
            isCalled = true;
        }
    }
}
