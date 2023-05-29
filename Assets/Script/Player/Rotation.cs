using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Transform weapon;
    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Vector3 point = hit.point;
            point.y = transform.position.y;
            transform.LookAt(point);
            //Debug.DrawRay(Camera.main.transform.position, ray.direction * 500, Color.red);

            //weapon.LookAt(transform.position);
            //weapon.Rotate(90, 0, 0);
            //if (point.x - transform.position.x >= 0)
            //{
            //    weapon.rotation = Quaternion.Euler(90, 0, 0);
            //}
            //else
            //{
            //    weapon.rotation = Quaternion.Euler(-90, 0, 0);
            //}
        }
    }
}
