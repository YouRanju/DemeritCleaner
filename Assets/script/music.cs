using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour {

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    private void Update()
    {
        if(Application.loadedLevel == 0 )
        {
            Destroy(this.gameObject);
        }
    }
}
