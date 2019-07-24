using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour {

    Rigidbody2D unicon;

    private void Start()
    {
        unicon = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update () {
		if(transform.position.x <= 17f)
        {
            unicon.velocity = Vector2.up;
        }
	}
}
