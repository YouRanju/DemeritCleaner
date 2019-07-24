﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TypeWriterEffect : MonoBehaviour
{
    public float delay;
    public int cnt;

    public string[] fulltext;
    public int dialog_cnt;
    string currentText;

    public bool text_exit;

    public string scene;
    public float de;

    float time = 0;

    void Start()
    {
        Get_Typing(dialog_cnt,fulltext);
    }

    void Update()
    {
        time += Time.deltaTime;

        if (time > de)
        {
            SceneManager.LoadScene(scene);
            time = 0;

            if (text_exit == true)
            {
                gameObject.SetActive(false);
            }
        }
        
    }

    public void Get_Typing(int _dialog_cnt, string[] _fullText)
    {
        text_exit = false;
        cnt = 0;

        dialog_cnt = _dialog_cnt;
        fulltext = new string[dialog_cnt];
        fulltext = _fullText;

        StartCoroutine(ShowText(fulltext));
    }

    IEnumerator ShowText(string[] _fullText)
    {
        if (cnt >= dialog_cnt)
        {
            text_exit = true;
            StopCoroutine("showText");
        }
        else
        {
            for (int i = 0; i < _fullText[cnt].Length; i++)
            {
                currentText = _fullText[cnt].Substring(0, i + 1);
                this.GetComponent<Text>().text = currentText;
                yield return new WaitForSeconds(delay);
            }
        }
    }
}
