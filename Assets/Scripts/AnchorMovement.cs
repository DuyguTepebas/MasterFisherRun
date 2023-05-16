using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchorMovement : MonoBehaviour
{
    [SerializeField] private float speed=1f;

    private void FixedUpdate()
    {
        StartCoroutine(nameof(MoveForwardRoutine));
    }


    IEnumerator MoveForwardRoutine()
    {
        while (true)
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.forward,
                speed * Time.deltaTime);
            transform.Rotate(10f,0f,0f ,Space.Self);
            yield return null;
        }
        
    }





}//class
