using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class DetectPlayer : MonoBehaviour
{
    public Canvas deathScreen;
    public TextMeshProUGUI timerText;
    
    private void Start()
    {
        deathScreen.gameObject.SetActive(false);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            deathScreen.gameObject.SetActive(true);
            timerText.gameObject.SetActive(false);
            
        }
        
    }

}
