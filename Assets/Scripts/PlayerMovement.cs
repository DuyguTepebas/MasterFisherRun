using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
   public float moveSpeed = 1f;
   public float swerveSpeed = 20f;
   private Vector2 _deltaTouchStart, _deltaTouchEnd, _dragDelta;
   private float _slideFactor = 0.1f;
   [SerializeField] private Vector2 boundaries;
   //[SerializeField] private AnchorMovement AnchorMovementScript;

   private void Update()
   {
      if (Input.GetMouseButtonDown(0))
      {
         SetTouchStart();
      }
      

      if (Input.GetMouseButton(0))
      {
         DragDeltaInput();
      }
   }

   void SetTouchStart()
   {
      _deltaTouchStart = Input.mousePosition;
      _deltaTouchEnd = Input.mousePosition;
      //AnchorMovementScript.StartMoveForwardRoutine();
   }
   
   // void SetTouchEnd()
   // {
   //    _touchEnd = Input.mousePosition;
   // }

   void DragDeltaInput()
   {
      //Debug.Log("deltaDragInput");
      _deltaTouchStart = Input.mousePosition;
      _dragDelta.x = (_deltaTouchEnd.x - _deltaTouchStart.x) * _slideFactor;
      _deltaTouchEnd = _deltaTouchStart;
      Swerve();
   }

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

      private float _positionOnX = 0;
      void Swerve()
      {
         //Debug.Log("swerve");
         _positionOnX = transform.position.x;
         _positionOnX = Mathf.Lerp(_positionOnX, _positionOnX - _dragDelta.x,
            Time.deltaTime * swerveSpeed);
         _positionOnX = Mathf.Clamp(_positionOnX, boundaries.x, boundaries.y); //boundrileri tek yerden belirleyebilmek için v2
         Vector3 newPosOnX = new Vector3(_positionOnX, transform.position.y, transform.position.z);
         transform.position = newPosOnX;
      }

   
}//class
