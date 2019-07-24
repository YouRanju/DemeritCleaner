using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    private bool GameOver = false;

    public static GameManager instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType(typeof(GameManager)) as GameManager;
            }

            return _instance;
        }
    }
    
    public bool gameOver
    {
        get { return GameOver; }
        set { GameOver = value; }
    }

    float fades = 0.0f;
    float time = 0;
    public Image fade;

    private void Update()
    {
        if(GameOver)
        {
            time += Time.deltaTime;

            if (fades < 1.0f && time >= 0.1f)
            {
                fades += time;
                fade.color = new Color(0, 0, 0, fades);
                time = 0;
            }
            else if (fades >= 1.0f)
            {
                SceneManager.LoadScene("2-1. Loading");
                time = 0;
            }
            
        }
    }
}
