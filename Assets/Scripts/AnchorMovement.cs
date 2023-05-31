using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchorMovement : MonoBehaviour
{
    [SerializeField] private float speed=1f;
    [SerializeField] private float maxDistance;
    private Quaternion targetRotation;
    private float _distance = 0f;
    public float MaxDistance
    {
        get => maxDistance;
        set => maxDistance = value;
    }

    public void StartMoveForwardRoutine()
    {
        StartCoroutine(nameof(MoveForwardRoutine));
    }
    IEnumerator MoveForwardRoutine()
    {
        // Calculate the target rotation based on the rotation angle
        while (true)
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.forward,
                speed * Time.deltaTime);
            transform.rotation = Quaternion.Lerp(transform.rotation, transform.rotation *= Quaternion.Euler(new Vector3(50f, 0f, 0f)), .1f);
            _distance += (speed * Time.deltaTime);
            if (_distance >= maxDistance)
            {
                Destroy(gameObject);
                yield break;
            }
            yield return null;
        }
    }

    // private void OnTriggerEnter(Collider other)
    // {
    //     Debug.Log(other.gameObject.name);
    // }
}//class
