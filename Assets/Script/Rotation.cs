using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Vector3 point = hit.point;
            point.y = transform.position.y;
            transform.LookAt(point);
            Debug.DrawRay(Camera.main.transform.position, ray.direction * 500, Color.red);
        }
    }
}
