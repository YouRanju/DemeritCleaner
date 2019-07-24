using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pattern : MonoBehaviour {

    private Rigidbody2D patternRB;
    public const float ENDPOSX = -24.0f;
    int cnt = 0;
    private static float _speed = 10f;

    public static float Speed {
        get { return _speed; }
        set { _speed = value;}
    }

    private void Start()
    {
        _speed = 10f;
    }

    public void Update()
    {
        patternRB = GetComponent<Rigidbody2D>();
        patternRB.velocity = new Vector2(-_speed, 0.0f);

        if (ENDPOSX >= transform.position.x)
        {
           Destroy(gameObject);
        }

        if (GameManager.instance.gameOver)
        {
            patternRB.velocity = Vector2.zero;
        }
    }
}
