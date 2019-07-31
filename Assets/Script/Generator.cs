using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    float rockRandTime, cherryRandTime, gemRandTime, tre1RandTime, tre2RandTime, pla1RandTime, pla2RandTime, vinRandTime, vin2RandTime, pla3RandTime, pla4RandTime;
    public GameObject rock, cherry, gem, tre1, tre2, pla1, pla2, vin,vin2, pla3, pla4, plaMon,fox,ghost,magicRock;
    GameObject ply;
    GameObject gst;
    Player script1;
    MoveObject script2;
    bool canSpawn = true;
    public bool isAppearedEnemy;
    bool isCalledEmeGenSwitch;
    int enemyGenCount;
    int level = 1;
    public bool magicDoing;

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
        StartCoroutine(EnemyGenController());

        ply = GameObject.Find("player");
        script1 = ply.GetComponent<Player>();
    }

    IEnumerator rockGen()
    {
        while (true)
        {
            rockRandTime = Random.Range(0.5f, 2.0f);
            yield return new WaitForSeconds(rockRandTime);
            if (canSpawn)
            {
                SpawnObj(rock);
            }
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

    IEnumerator EnemyGenController()
    {
        int previousScore = 0;
        int currentScore = 0;
        while (true)
        {
            currentScore = Score.GetScore();
            if (previousScore != currentScore)
            {
                if (currentScore >= 30 && currentScore < 60)
                {
                    level = 2;
                }else if(currentScore >= 60 && currentScore < 90){
                    level = 3;
                }else if(currentScore >= 90 && currentScore < 120){
                    level = 4;
                }else if(currentScore >= 120){
                    level = 5;
                }
                enemyGenCount++;
                previousScore = currentScore;
                isCalledEmeGenSwitch = false;
            }
            if (currentScore < 15)
            {
                isCalledEmeGenSwitch = true;
                enemyGenCount = 0;
            }
            if (!isAppearedEnemy && !isCalledEmeGenSwitch)
            {
                isCalledEmeGenSwitch = true;
                switch (enemyGenCount)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        if (level == 5) enemyGenByProbability(100.0f);
                        break;
                    case 5:
                        enemyGenByProbability(5.0f * level);
                        break;
                    case 6:
                        enemyGenByProbability(10.0f * level);
                        break;
                    case 7:
                        enemyGenByProbability(15.0f * level);
                        break;
                    case 8:
                        enemyGenByProbability(20.0f * level);
                        break;
                    case 9:
                        enemyGenByProbability(25.0f * level);
                        break;
                    case 10:
                        enemyGenByProbability(30.0f * level);
                        break;
                    case 11:
                        enemyGenByProbability(35.0f * level);
                        break;
                    case 12:
                        enemyGenByProbability(40.0f * level);
                        break;
                    case 13:
                        enemyGenByProbability(60.0f * level);
                        break;
                    case 14:
                        enemyGenByProbability(80.0f * level);
                        break;
                    case 15:
                        enemyGenByProbability(100.0f * level);
                        break;
                }
            }
            yield return null;
        }
    }

    IEnumerator plaMonGen()
    {
        canSpawn = false;
        yield return new WaitForSeconds(1.3f);
        SpawnObj(rock);
        for (int i = 0; i < 2; i++)
        {
            yield return new WaitForSeconds(0.65f);
            SpawnObj(rock);
        }
        SpawnObj(plaMon);
        yield return new WaitForSeconds(0.7f);
        SpawnObj(rock);
        script1.isPoison = true;
        for (int i = 0; i < 13; i++)
        {
            rockRandTime = Random.Range(0.65f, 0.8f);
            yield return new WaitForSeconds(rockRandTime);
            SpawnObj(rock);
        }
        yield return new WaitForSeconds(2.0f);
        SpawnObj(rock);
        yield return new WaitForSeconds(0.65f);
        SpawnObj(rock);
        yield return new WaitForSeconds(0.65f);
        SpawnObj(rock);
        yield return new WaitForSeconds(0.7f);
        script1.isPoison = false;
        SpawnObj(rock);
        canSpawn = true;
        isAppearedEnemy = false;
        enemyGenCount = 0;
    }

    IEnumerator foxGen()
    {
        canSpawn = false;
        yield return new WaitForSeconds(0.4f);
        SpawnObj(fox);
        yield return new WaitForSeconds(0.4f);
        canSpawn = true;
        isAppearedEnemy = false;
        enemyGenCount = 0;
    }

    IEnumerator ghostGen()
    {
        SpawnObj(ghost);
        yield return new WaitForSeconds(1.0f);
        canSpawn = false;
        magicDoing = true;
        yield return new WaitForSeconds(1.5f);
        gst = GameObject.Find("ghost(Clone)");
        script2 = gst.GetComponent<MoveObject>();
        while (script2.ghostgettingReady) yield return null;
        int ghostRand = Random.Range(1, 4);
        switch (ghostRand)
        {
            case 1:
                StartCoroutine("rockGenByGhost1");
                break;
            case 2:
                StartCoroutine("rockGenByGhost2");
                break;
            case 3:
                StartCoroutine("rockGenByGhost3");
                break;
        }
        while (magicDoing) yield return null;
        yield return new WaitForSeconds(1.5f);
        canSpawn = true;
        isAppearedEnemy = false;
        enemyGenCount = 0;
    }

    IEnumerator rockGenByGhost1()
    {
        for(int i = 0; i < 4; i++)
        {
            SpawnMagicRock(0);
            SpawnMagicRock(1);
            yield return new WaitForSeconds(1.0f);
            SpawnMagicRock(1);
            SpawnMagicRock(2);
            yield return new WaitForSeconds(1.0f);
        }
        magicDoing = false;
    }

    IEnumerator rockGenByGhost2()
    {
        int magicRand;
        for (int i = 0; i < 6; i++)
        {
            magicRand = Random.Range(0, 2);
            if(magicRand==0)
            {
                SpawnMagicRock(0);
                SpawnMagicRock(1);
            }
            else
            {
                SpawnMagicRock(1);
                SpawnMagicRock(2);
            }
            yield return new WaitForSeconds(0.67f);
            SpawnMagicRock(0);
            SpawnMagicRock(2);
            yield return new WaitForSeconds(0.67f);
        }
        magicDoing = false;
    }

    IEnumerator rockGenByGhost3()
    {
        int magicRand;
        for (int i = 0; i < 4; i++)
        {
            magicRand = Random.Range(0, 2);
            for (int j = 0; j < 5; j++)
            {
                SpawnMagicRock(1);
                yield return new WaitForSeconds(0.3f);
            }
            yield return new WaitForSeconds(0.5f);
            for (int j = 0; j < 4; j++)
            {
                SpawnMagicRock(1);
                yield return new WaitForSeconds(0.3f);
            }
            if (magicRand == 0)
            {
                SpawnMagicRock(0);
                SpawnMagicRock(1);
            }
            else
            {
                SpawnMagicRock(1);
                SpawnMagicRock(2);
            }
        }
        magicDoing = false;
    }

    void SpawnObj(GameObject obj)
    {
        Instantiate(obj.gameObject, transform.position, Quaternion.identity);
    }

    void SpawnMagicRock(int row)
    {
        switch (row)
        {
            case 0:
                Instantiate(magicRock.gameObject, new Vector3(12, -0.95f, 0), Quaternion.identity);
                break;
            case 1:
                Instantiate(magicRock.gameObject, new Vector3(12, -1.95f, 0), Quaternion.identity);
                break;
            case 2:
                Instantiate(magicRock.gameObject, new Vector3(12, -3.2f, 0), Quaternion.identity);
                break;
        }
    }

    void enemyGenByProbability(float fPercent)
    {
        int enemyRand = Random.Range(0, 10);
        float fProbabilityRate = UnityEngine.Random.value * 100.0f;
        if (fProbabilityRate < fPercent)
        {
            switch (enemyRand)
            {
                case 0: 
                case 1: 
                case 2:
                case 3:
                case 4:
                    StartCoroutine("foxGen");
                    isAppearedEnemy = true;
                    break;
                case 5:
                case 6:
                case 7:
                    StartCoroutine("ghostGen");
                    isAppearedEnemy = true;
                    break;
                case 8:
                case 9:
                    StartCoroutine("plaMonGen");
                    isAppearedEnemy = true;
                    break;
            }
        }
    }

    public bool getisAppeareedEnemy()
    {
        return isAppearedEnemy;
    }
}
