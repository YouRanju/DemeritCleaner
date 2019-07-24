using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour {

    public GameObject obj = null;
    public float _startPosition;
    public float _endPosition;

    public float speed = 0.3f;

    public void Update()
    {
        Move();
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
    }
}
