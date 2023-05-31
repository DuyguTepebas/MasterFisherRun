using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> levels = new List<GameObject>();
    private int _levelIndex;

    private void Start()
    {
        SetLevel();
    }
    
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)) Restart();
    }

    void SetLevel()
    {
        _levelIndex = PlayerPrefs.GetInt("Level", 0);
        _levelIndex %= 2;
        levels[_levelIndex].SetActive(true);
        _levelIndex++;
        PlayerPrefs.SetInt("Level", _levelIndex);
    }
    
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}// Class
