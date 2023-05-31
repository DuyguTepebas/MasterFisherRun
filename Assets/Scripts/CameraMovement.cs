using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform target;

    private void LateUpdate()
    {
        Move();
    }
    
    public void Move()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, target.position.z);
    }

    public void RotateCam()
    {
        transform.Rotate(new Vector3(0,-20,0));
    }

}//class
