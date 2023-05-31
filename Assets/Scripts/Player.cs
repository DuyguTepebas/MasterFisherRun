using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private UIManager _uiManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Worm"))
        {
            Debug.Log("wormCollected");
            _uiManager.wormHolder++;
            _uiManager.UpdateWormText();
            Destroy(other.gameObject);
        }
    }
}//class
