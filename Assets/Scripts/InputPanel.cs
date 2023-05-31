using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InputPanel : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private ThrowingBehaviour throwingBehaviour;
    
    
    
    public void OnPointerDown(PointerEventData eventData)
    {
        playerMovement.StartMoveForwardRoutine();
        throwingBehaviour.SetAnimEnable();
        gameObject.SetActive(false);
    }
}//class
