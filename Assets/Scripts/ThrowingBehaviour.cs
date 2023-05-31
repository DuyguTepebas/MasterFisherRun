using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ThrowingBehaviour : MonoBehaviour
{
    [SerializeField] public float throwingRate;
    [SerializeField] public float throwingRange;
    [SerializeField] private Transform throwingStartPoint;
    [SerializeField] private GameObject anchor;
    [SerializeField] private AnchorMovement anchorMovementScript;
    [SerializeField] private GameObject anchorInTheHand;
    [SerializeField] private GameObject anchors;
    [SerializeField] private Door doorScript;
    [SerializeField] private Animator anim;


    // private void Update()
    // {
    //     anim.speed = throwingRate;
    // }

    void Throw()
    {
        anchorInTheHand.SetActive(false);
        anchorMovementScript = Instantiate(anchor, throwingStartPoint.position, Quaternion.identity, anchors.transform).GetComponent<AnchorMovement>();
        anchorMovementScript.MaxDistance = throwingRange;
        anchorMovementScript.StartMoveForwardRoutine();
    }

    void Retract()
    {
        anchorInTheHand.SetActive(true);
    }

    public void FishingAnim()
    {
        anim.CrossFade("Fishing", .3f);
    }

    public void SetThrowingRange(float value)
    {
        throwingRange += value;
    }
   
    public void SetThrowingRate(float value)
    {
        throwingRate += value * .1f;
        anim.speed = throwingRate;
    }


    public void SetAnimEnable()
    {
        anim.enabled = true;
    }
}//class
