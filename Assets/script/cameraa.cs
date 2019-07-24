using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraa : MonoBehaviour {

    [SerializeField]
    private Camera camera = null;
    // Use this for initialization
    void Start () {
        // camera.aspect = 600.0f / 800.0f
        camera.aspect = 1600.0f / 1200.0f;
        //Screen.SetResolution(1600, 1200, false);
        

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
