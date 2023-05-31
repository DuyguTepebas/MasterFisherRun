using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowingBehaviour : MonoBehaviour
{
    [SerializeField] private float throwingRate;
    [SerializeField] private Transform throwingStartPoint;
    [SerializeField] private GameObject anchor;
    [SerializeField] private AnchorMovement anchorMovementScript;
    [SerializeField] private GameObject anchorInTheHand;



    void Throw()
    {
        anchorInTheHand.SetActive(false);
        anchorMovementScript = Instantiate(anchor, throwingStartPoint.position, Quaternion.identity).GetComponent<AnchorMovement>();
        anchorMovementScript.StartMoveForwardRoutine();
    }

    void Retract()
    {
        anchorInTheHand.SetActive(true);
    }
    
}//class
