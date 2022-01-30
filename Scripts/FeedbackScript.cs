using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedbackScript : MonoBehaviour
{
    public Transform prefab;

    void Update()
    {
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z += Camera.main.nearClipPlane;
            mousePosition.x += 0.05f;
            mousePosition.y -= 0.05f;
            
            prefab.position = mousePosition;
        }
    }
}
