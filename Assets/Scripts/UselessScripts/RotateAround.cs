using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public Transform target;
    public float RotationSpeed = 100f;
    public float OrbitDegrees = 1f;

    void Update()
    {
    transform.position =
    RotatePointAroundPivot(transform.position,
                           target.position,
                           Quaternion.Euler(0, OrbitDegrees * Time.deltaTime, 0));
    }



    public static Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Quaternion angle)
    {
        return angle * (point - pivot) + pivot;
    }

}
