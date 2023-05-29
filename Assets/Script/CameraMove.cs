using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform target;
    public float direction;

    private void Update()
    {
        Vector3 pos = target.position;
        pos.y = direction;

        transform.position = pos;
    }
}
