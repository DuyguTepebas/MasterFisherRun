using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fishing : MonoBehaviour
{
    [SerializeField] private GameObject fish;
    [SerializeField] private Transform hook;
    [SerializeField] private float moveSpeed;
    [SerializeField] private Animator anim;
    [SerializeField] private UIManager uiManager;
    private GameObject _caughtFish;
    

    public void ThrowBait()
    {
        if (uiManager.wormHolder <= 0)
        {
            uiManager.Success();
            return;
        }
        StartCoroutine(nameof(DescendHookRoutine));
        uiManager.wormHolder--;
        uiManager.UpdateWormText();
    }
    
    IEnumerator DescendHookRoutine()
    {
        while (true)
        {
            hook.position = Vector3.Lerp(hook.position, hook.position + Vector3.down,
                moveSpeed * Time.deltaTime);

            if (hook.localPosition.y <= 6f)
            {
                _caughtFish = Instantiate(fish, hook.position, Quaternion.identity, hook);
                StartCoroutine(nameof(AscendHookRoutine));
                yield break;
            }
            yield return null;
        }
    }

    IEnumerator AscendHookRoutine()
    {
        while (true)
        {
            hook.position = Vector3.Lerp(hook.position, hook.position + Vector3.up,
                moveSpeed * Time.deltaTime);

            if (hook.localPosition.y >= 11f)
            {
                _caughtFish.SetActive(false);
                PlayAnim();
                yield break;
            }
            yield return null;
        }
    }

    void PlayAnim()
    {
        anim.Play("Fishing", -1,0f);
    }
}
