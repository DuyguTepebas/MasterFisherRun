using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text wormHolderText;
    [SerializeField] private GameObject button;
    public int wormHolder=0;

    public void UpdateWormText()
    {
        wormHolderText.text = "Worm: " + wormHolder;
    }

    public void Success()
    {
        button.SetActive(true);
    }
}// class
