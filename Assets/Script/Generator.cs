using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    float rockRandTime, cherryRandTime, gemRandTime, tre1RandTime, tre2RandTime, pla1RandTime, pla2RandTime, vinRandTime, vin2RandTime, pla3RandTime, pla4RandTime;
    public GameObject rock, cherry, gem, tre1, tre2, pla1, pla2, vin,vin2, pla3, pla4;

    void Start()
    {
        StartCoroutine(rockGen());
        StartCoroutine(cherryGen());
        StartCoroutine(gemGen());
        StartCoroutine(tre1Gen());
        StartCoroutine(tre2Gen());
        StartCoroutine(pla1Gen());
        StartCoroutine(pla2Gen());
        StartCoroutine(vinGen());
        StartCoroutine(vin2Gen());
        StartCoroutine(pla3Gen());
        StartCoroutine(pla4Gen());
    }

    IEnumerator rockGen()
    {
        while (true)
        {
            rockRandTime = Random.Range(0.5f, 2.0f);
            yield return new WaitForSeconds(rockRandTime);
            SpawnObj(rock);

        }
    }

    IEnumerator cherryGen()
    {
        while (true)
        {
            cherryRandTime = Random.Range(0.5f, 2.0f);
            yield return new WaitForSeconds(cherryRandTime);
            SpawnObj(cherry);
        }
    }

    IEnumerator gemGen()
    {
        while (true)
        {
            gemRandTime = Random.Range(10.0f, 15.0f);
            yield return new WaitForSeconds(gemRandTime);
            SpawnObj(gem);
        }
    }

    IEnumerator tre1Gen()
    {
        while (true)
        {
            tre1RandTime = Random.Range(1.5f, 2.0f);
            yield return new WaitForSeconds(tre1RandTime);
            SpawnObj(tre1);
        }
    }

    IEnumerator tre2Gen()
    {
        while (true)
        {
            tre2RandTime = Random.Range(4.0f, 5.0f);
            yield return new WaitForSeconds(tre2RandTime);
            SpawnObj(tre2);
        }
    }

    IEnumerator pla1Gen()
    {
        while (true)
        {
            pla1RandTime = Random.Range(0.8f, 2.0f);
            yield return new WaitForSeconds(pla1RandTime);
            SpawnObj(pla1);
        }
    }

    IEnumerator pla2Gen()
    {
        while (true)
        {
            pla2RandTime = Random.Range(0.8f, 2.0f);
            yield return new WaitForSeconds(pla2RandTime);
            SpawnObj(pla2);
        }
    }

    IEnumerator vinGen()
    {
        while (true)
        {
            vinRandTime = Random.Range(4.0f, 6.0f);
            yield return new WaitForSeconds(vinRandTime);
            SpawnObj(vin);
        }
    }
    IEnumerator vin2Gen()
    {
        while (true)
        {
            vin2RandTime = Random.Range(6.0f, 7.0f);
            yield return new WaitForSeconds(vin2RandTime);
            SpawnObj(vin2);
        }
    }

    IEnumerator pla3Gen()
    {
        while (true)
        {
            pla3RandTime = Random.Range(2.5f, 3.0f);
            yield return new WaitForSeconds(pla3RandTime);
            SpawnObj(pla3);
        }
    }

    IEnumerator pla4Gen()
    {
        while (true)
        {
            pla4RandTime = Random.Range(6.0f, 7.0f);
            yield return new WaitForSeconds(pla4RandTime);
            SpawnObj(pla4);
        }
    }

    void SpawnObj(GameObject obj)
    {
        Instantiate(obj.gameObject, transform.position, Quaternion.identity);
    }

}
