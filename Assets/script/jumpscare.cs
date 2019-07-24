using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpscare : MonoBehaviour {


    public GameObject Img;
    public GameObject Img2;
    float time;
	// Use this for initialization

	void Start () {
        Img.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        Img2.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
    }
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;

        if(time >= 6f)
        {
            Img.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.09f);

            if(time >=6.2f)
            {
                Img.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0f);
            }
        }
        if (time >= 10f)
        {
            Img.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.1f);

            if (time >= 10.2f)
            {
                Img.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0f);
            }
        }
        if (time >= 16f)
        {
            Img.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, .12f);

            if (time >= 16.2f)
            {
                Img.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0f);
            }
        }
        if (time >= 22f)
        {
            Img2.SetActive(true);
            Img2.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            Img2.GetComponent<Transform>().localScale = new Vector3(1f, 1f);

            if (time >= 23f)
            {
                Img2.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0f);
            }
        }
    }
}
