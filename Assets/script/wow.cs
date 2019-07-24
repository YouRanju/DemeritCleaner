using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wow : MonoBehaviour {

    private static int _rand;

    public static int random
    {
        get { return _rand; }
    }

    void Start () {

        _rand = Random.Range(1, 3);

        if (_rand <= 1)
        {
            SceneManager.LoadScene("1. Title");
        } else
        {
            SceneManager.LoadScene("1-2. Title");
        }
    }
	
}
