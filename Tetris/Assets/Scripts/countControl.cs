using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countControl : MonoBehaviour
{
    float StartCount;
    float MultiCount;
    public Text Count;


    void Start()
    {
        StartCount = 0f;
        MultiCount = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        StartCount += Time.deltaTime * MultiCount;
        Count.text = "" + Mathf.Round(StartCount);
    }
}
