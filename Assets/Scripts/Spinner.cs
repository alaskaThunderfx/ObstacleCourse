using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField]
    float xAxis;

    [SerializeField]
    float yAxis;

    [SerializeField]
    float zAxis;

    private void Update()
    {
        transform.Rotate(xAxis, yAxis, zAxis);
    }
}
