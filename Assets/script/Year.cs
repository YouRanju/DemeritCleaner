using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Year : MonoBehaviour {

    public GameObject obj;
    public Text scorepath;
    public Text Score;

    float time = 0;
    float fade = 1.0f;
    bool gugu = false;

	void Update () {

        time += Time.deltaTime;

        fade -= time;
       
        obj.GetComponent<SpriteRenderer>().color = new Color(fade, 0, 0);
        if (time > 14.9f && !gugu)
        {
            scorepath.text = "";
            Score.text = "";
            gugu = true;
        }
        if(time > 15f) scorepath.text += "?";
        if (time > 4f) obj.transform.localScale = new Vector3(Random.Range(-5, 10), Random.Range(-5, 2), 0);

        if (time > 4.5f)
        {
            obj.transform.localScale = new Vector3(0.7f, 0.7f, 0);
        }

        if (time > 10f) obj.transform.localScale = new Vector3(Random.Range(-5, 10), Random.Range(-5, 2), 0);

        if (time > 11f)
        {
            obj.transform.localScale = new Vector3(0.7f, 0.7f, 0);
        }

    }
}
