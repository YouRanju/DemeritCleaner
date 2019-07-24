using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class grade : MonoBehaviour {

    public Sprite[] image;

    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = image[0];
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Bae")
        {
            GetComponent<SpriteRenderer>().sprite = image[1];
        }
    }

}
