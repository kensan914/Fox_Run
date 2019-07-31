using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankingForm : MonoBehaviour
{
    int score = Score.GetScore();
    List<string> nameList;
    List<int> scoreList;
    int rank;
    string[] nameKey = { "n1", "n2", "n3", "n4", "n5", "n6", "n7", "n8", "n9", "n10" };
    string[] scoreKey = { "s1", "s2", "s3", "s4", "s5", "s6", "s7", "s8", "s9", "s10" };
    Transform rankingText;
    public InputField nameInput;

    // Start is called before the first frame update
    void Start()
    {
        nameList = LoadRunkingName();
        scoreList = LoadRunkingScore();
        rankingText = transform.Find("rankingText");
        if (scoreList.Count < 10 || scoreList[scoreList.Count - 1] < score)
        {
            gameObject.SetActive(true);
            rank = RankJudge(scoreList);
            rankingText.gameObject.GetComponent<Text>().text = "おめでとうございます！今回あなたはランキング" + rank.ToString() + "位に輝きました。ニックネームを入力してランキングに記録しましょう!";
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    List<string> LoadRunkingName()
    {
        List<string> nameList = new List<string>();
        for(int i=0; i < 10; i++)
        {
            if (PlayerPrefs.HasKey(nameKey[i]))
            {
                nameList.Add(PlayerPrefs.GetString(nameKey[i], null));
            }
            else break;
        }
        return nameList;
    }

    List<int> LoadRunkingScore()
    {
        List<int> scoreList = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            if (PlayerPrefs.HasKey(scoreKey[i]))
            {
                scoreList.Add(PlayerPrefs.GetInt(scoreKey[i], 0));
            }
            else break;
        }
        return scoreList;
    }

    int RankJudge(List<int> scoreList)
    {
        int rank = 1;
        int i;
        if (scoreList.Count == 0)
        {
            return rank = 1;
        }
        for(i = 0; i < scoreList.Count; i++)
        {
            if (scoreList[i] >= score)
            {
                rank++;
            }
            else
            {
                return rank;
            }
        }
        return i+1;
    }

    List<string> UpdateNameList(List<string> nameList, int rank, string newName)
    {
        List<string> newNameList = new List<string>();
        if (newName.Equals(null)) newName = "名無し";
        if (nameList.Count == 0)
        {
            newNameList.Add(newName);
            return newNameList;
        }
        for(int i = 0; i < nameList.Count + 1; i++)
        {
            if (rank == i + 1)
            {
                newNameList.Add(newName);
            }
            if(i != nameList.Count && i != nameList.Count-1) newNameList.Add(nameList[i]);
        }
        return newNameList;
    }

    List<int> UpdateScoreList(List<int> scoreList, int rank)
    {
        List<int> newScoreList = new List<int>();
        if (nameList.Count == 0)
        {
            newScoreList.Add(score);
            return newScoreList;
        }
        for (int i = 0; i < scoreList.Count + 1; i++)
        {
            if (rank == i + 1)
            {
                newScoreList.Add(score);
            }
            if (i != scoreList.Count && i != scoreList.Count-1) newScoreList.Add(scoreList[i]);
        }
        return newScoreList;
    }

    public void UpdateRanking()
    {
        List<string> newNameList = UpdateNameList(nameList, rank, nameInput.text);
        List<int> newScoreList = UpdateScoreList(scoreList, rank);
        for(int i = 0; i < newScoreList.Count; i++)
        {
            PlayerPrefs.SetString(nameKey[i], newNameList[i]);
            PlayerPrefs.SetInt(scoreKey[i], newScoreList[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
