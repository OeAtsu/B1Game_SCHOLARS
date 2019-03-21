using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoPointCenter : MonoBehaviour
{

    public Transform point1, point2, point3;

    void LateUpdate()
    {
        point3.position = (point1.position + point2.position) / 2;
        Debug.Log(point3);
        gameObject.GetComponent<Transform>().position = point3.position;
    }
}
