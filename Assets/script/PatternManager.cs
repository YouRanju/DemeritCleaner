using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternManager : MonoBehaviour
{
    private int RandomPattern = 0;

    private List<GameObject> patternList = new List<GameObject>();
    public GameObject StartPattern;
    public GameObject pattern1;
    public GameObject pattern2;
    public GameObject pattern3;
    public GameObject pattern4;
    public GameObject pattern5;

    public float Speed = 0.0f;
    public float delayTime = 0.0f;
    public float posX = 0.0f;
    
    private void Start()
    {
        patternList.Add(pattern1);
        patternList.Add(pattern2);
        patternList.Add(pattern3);
        patternList.Add(pattern4);
        patternList.Add(pattern5);
        StartCoroutine("CreatePattern");
    }

    IEnumerator CreatePattern()
    {
        GameObject s_pattern = Instantiate(StartPattern, new Vector2(0.0f, 0f), Quaternion.identity);
        s_pattern.GetComponent<pattern>().Update();

        while (!GameManager.instance.gameOver)
        {
            RandomPattern = Random.Range(0, 5);

            GameObject t_pattern = Instantiate(patternList[RandomPattern], new Vector2(48, 0f), Quaternion.identity);
            t_pattern.GetComponent<pattern>().Update();
            yield return new WaitForSeconds(delayTime);
        }
    }

}
