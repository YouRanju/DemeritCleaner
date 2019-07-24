using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Totitle : MonoBehaviour {

    public Image fade;

    private bool iskey = false;

    float fades = 1.0f;
    float time = 0;

    public void Update()
    {
        if(!iskey)
        {
            time += Time.deltaTime;

            if (fades <= 1.0f && time >= 0.1f)
            {
                fades -= time;
                fade.color = new Color(0, 0, 0, fades);
                time = 0;
            }
            else if (fades <= 0.0f)
            {
                time = 0;
            }
        }

        if (Input.anyKey)
        {
            iskey = true;
        }

        if (iskey)
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
                
                SceneManager.LoadScene("0. Loading");
                time = 0;
            }
        }
    }
}
