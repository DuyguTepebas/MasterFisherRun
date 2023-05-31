using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    [SerializeField] private DoorType doorType = DoorType.ThrowingRange;
    [SerializeField] private TMP_Text descriptionText, valueText;
    [SerializeField] public float value;
    private const string _rangeText = "RANGE";
    private const string _rateText = "FIRE RATE";

    private void Start()
    {
        SetDoorType();
    }

    void SetDoorType()
    {
        switch (doorType)
        {
            case DoorType.ThrowingRange:
                descriptionText.text = _rangeText;
                valueText.text = value.ToString();
                break;
            case DoorType.ThrowingRate:
                descriptionText.text = _rateText;
                valueText.text = value.ToString();
                break;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Anchor"))
        {
            IncreaseValue();
            Destroy(other.gameObject);
        }

        if (other.gameObject.GetComponent<ThrowingBehaviour>())
        {
            PlayerEnterTheGate(other.gameObject.GetComponent<ThrowingBehaviour>());
        }
    }

    private void IncreaseValue()
    {
        value++;
        valueText.text = value.ToString();
    }

    void PlayerEnterTheGate(ThrowingBehaviour throwingBehaviour)
    {
        switch (doorType)
        {
            case DoorType.ThrowingRange:
                throwingBehaviour.SetThrowingRange(value);
                break;
            case DoorType.ThrowingRate:
                throwingBehaviour.SetThrowingRate(value);
                break;
        }
    }
    
    
    
}//class


public enum DoorType
{
    ThrowingRange,
    ThrowingRate,
}
