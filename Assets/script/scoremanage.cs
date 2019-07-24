using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoremanage : MonoBehaviour {


    public Text grade;

    private void Start()
    {
        grade.text = movemanage.Score.ToString();
    }
}
