using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
   public float moveSpeed = 10f;

   


   IEnumerator MoveForwardRoutine()
   {
      while (true)
      {
         transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.forward,
            moveSpeed * Time.deltaTime);
         yield return null;
      }
   }

   public void StartMoveForwardRoutine()
   {
      StartCoroutine(nameof(MoveForwardRoutine));
   }





}//class
