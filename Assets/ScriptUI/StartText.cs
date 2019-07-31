using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartText : MonoBehaviour
{
    public Text text;
    float alfa = 1;
    public float speed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Count");
    }

    // Update is called once per frame
    void Update()
    {
        text.color = new Color(255f/255f, 123f/255f, 0, alfa);
        alfa -= speed;
        text.fontSize += 1;
    }

    IEnumerator Count()
    {
        yield return new WaitForSeconds(2);
        text.enabled = false;
    }
}
