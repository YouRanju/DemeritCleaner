using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movemanage : MonoBehaviour
{
    private static float _score = -29.5f;

    public static float Score
    {
        get { return _score; }
    }

    public PolygonCollider2D BaeRun;
    public PolygonCollider2D BaeSlide;
    public Text ScoreText;
    public Text t;
    public Sprite[] runImg;
    public Sprite[] slideImg;

    private Rigidbody2D BaeRigid;
    private const float POWER = 7.0f;
    private bool jump = false;
    private bool slide = false;
    private int jumpCount = 0;
    private int r = 0;

    private void Start()
    {
        BaeRigid = GetComponent<Rigidbody2D>();

        _score = -29.5f;
        ScoreRenew();

       //StartCoroutine("NextPage");

        GetComponent<SpriteRenderer>().sprite = runImg[0];
    }

    private void FixedUpdate()
    {
        if (jumpCount > 0 && jump)
        {
            BaeRigid.velocity = (Vector2.up * POWER);
            jump = false;
        }
    }

    private void Update()
    {
        r++;

        if (r >= runImg.Length)
        {
            r = 0;
        }

        if (!slide)
        {
            GetComponent<SpriteRenderer>().sprite = runImg[r];
            BaeRun.enabled = true;
            BaeSlide.enabled = false;
        }
        
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            slide = true;
            BaeSlide.enabled = true;
            BaeRun.enabled = false;

            for (int i = 0; i < slideImg.Length; i++)
            {
                GetComponent<SpriteRenderer>().sprite = slideImg[i];
            }
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            slide = false;
            BaeRun.enabled = true;
            BaeSlide.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && jumpCount < 1 && !slide)
        {
            jumpCount++;
            jump = true;
        }

        if (transform.position.y < -10)
        {
            GameManager.instance.gameOver = true;
        }

        if (transform.position.y <= -1f && transform.position.y >= -1.2f)
        {
            jumpCount = 0;
            jump = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Trap"))
        {
            GameManager.instance.gameOver = true;
        }

        if (collision.CompareTag("Score"))
        {
            _score += 0.5f;
            ScoreRenew();
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Dove"))
        {
            pattern.Speed -= 2f;

            if (pattern.Speed < 1)
            {
                pattern.Speed = 0.2f;
            }

            t.text = "스피드 감소!!!";
        }
    }

    void ScoreRenew()
    {
        if (wow.random == 1)
        {
            ScoreText.text = Score.ToString();
        } else { }
    }
}
