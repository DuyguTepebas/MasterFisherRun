using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject runnerEnvironment, simulationEnvironment;
    [SerializeField] private PlayerMovement playerMovementScript;
    [SerializeField] private ThrowingBehaviour throwingBehaviourScript;
    [SerializeField] private CameraMovement cameraMovement;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerMovementScript.StopMoveRoutine();
            throwingBehaviourScript.FishingAnim();
            runnerEnvironment.SetActive(false);
            simulationEnvironment.SetActive(true);
            cameraMovement.RotateCam();
        }
    }
}//
