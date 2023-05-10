using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InputPanel : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private PlayerMovement playerMovement;
    
    
    
    public void OnPointerDown(PointerEventData eventData)
    {
        playerMovement.StartMoveForwardRoutine();
        gameObject.SetActive(false);
    }
}//class
