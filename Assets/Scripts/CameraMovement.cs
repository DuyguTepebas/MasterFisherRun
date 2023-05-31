using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform target;

    private void LateUpdate()
    {
        Move();
    }

    private Vector3 constantPosition;
    public void Move()
    {
        constantPosition.z = transform.position.z - target.position.z;
        transform.position = new Vector3(transform.position.x, transform.position.y,
            transform.position.z + constantPosition.z )*Time.deltaTime;
    }

}//class
