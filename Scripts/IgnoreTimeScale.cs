using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreTimeScale : MonoBehaviour
{
    void Update()
    {
        if (Time.timeScale < 0.01f)
        {
            // Debug.Log("Ignore Time!!!");
            GetComponent<ParticleSystem>().Simulate(Time.unscaledDeltaTime, true, false);
        }
    }
}
