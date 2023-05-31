using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChestCollision : MonoBehaviour
{
    private BoxCollider chestBoxCollider;
    private int chestHealth=2;
    [SerializeField] private Animator anim;
    private void Awake()
    {
        chestBoxCollider= transform.GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        ReceiveDamage();
        anim.SetTrigger("ChestOpen");
    }

    private void ReceiveDamage()
    {
        chestHealth--;
        chestHealth = Mathf.Max(chestHealth, 0);
        Debug.Log(chestHealth);
        if(chestHealth <= 0) OpenChest();
    }

    void OpenChest()
    {
        chestBoxCollider.enabled = false;
        Debug.Log("OpenChest");
    }
}//class
