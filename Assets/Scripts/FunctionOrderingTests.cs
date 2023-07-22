using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionOrderingTests : MonoBehaviour
{
    float t = 2000;

    private void Awake()
    {
        Log("Awake()");
    }
    private void OnEnable()
    {
        Log("OnEnable()");
    }
    void Reset()
    {
        t = 2;
        Log("Reset()");
    }
    void Start()
    {
        Log("Start()");
    }

    void Update()
    {

    }

    private void FixedUpdate()
    {
        t -= Time.fixedDeltaTime;
        if (t <= 0)
        {
            t = 1000;
            Instantiate(this);
        }
    }

    void Log(string st)
    {
        Debug.Log(name+": "+st);
    }
}
