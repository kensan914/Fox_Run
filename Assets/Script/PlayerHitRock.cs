using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitRock : MonoBehaviour
{
    public bool HitMassage; 
    bool rockTotch = false,isntTotched = true;
    //int count;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (rockTotch)
        {
            rockTotch = false;
            HitMassage = true;
            gameObject.SetActive(false);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "rock tag" && gameObject.GetComponent<Renderer>().sortingOrder == other.gameObject.GetComponent<Renderer>().sortingOrder && isntTotched)
        {
            rockTotch = true;
            isntTotched = false;
        }
    }
}
