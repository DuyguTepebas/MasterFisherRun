using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchorMovement : MonoBehaviour
{
    [SerializeField] private float speed=1f;
    private Quaternion startRotation;
    private Quaternion targetRotation;
    

    public void StartMoveForwardRoutine()
    {
        StartCoroutine(nameof(MoveForwardRoutine));
    }
    IEnumerator MoveForwardRoutine()
    {
        startRotation = transform.rotation;

        // Calculate the target rotation based on the rotation angle
        while (true)
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.forward,
                speed * Time.deltaTime);
            transform.rotation = Quaternion.Lerp(transform.rotation, transform.rotation *= Quaternion.Euler(new Vector3(10f, 0f, 0f)), .1f);
            yield return null;
        }
    }





}//class
