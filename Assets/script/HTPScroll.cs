using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HTPScroll : MonoBehaviour {

    public string[] HTP;
    public GameObject obj;

    public float _startPosition = 5000f;
    public float _endPosition = -2000f;

    public float speed = 20f;
    int i;

    public void Start()
    {
        i = 0;
    }

    public void Update()
    {
        if (i == HTP.Length)
        {
            obj.SetActive(false);
            i = HTP.Length;
        }
        else
        {
            GetComponent<Text>().text = HTP[i];

            Move();
        }
    }

    private void Move()
    {
        Vector3 result = transform.position;
        result.x -= speed;
        if (result.x < _endPosition)
        {
            FinishEndPosition();
        }
        else
        {
            transform.position = result;
        }        
    }

    private void FinishEndPosition()
    {
        Vector3 result = transform.position;
        result.x = _startPosition;
        transform.position = result;

        i++;
    }
}
