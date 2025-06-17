using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class WinScript : MonoBehaviour
{

    public TextMeshProUGUI timerText;
    public Canvas winScreen;
    public Rigidbody2D playerRb;
    
    void Start()
    {
        winScreen.gameObject.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            winScreen.gameObject.SetActive(true);
            timerText.gameObject.SetActive(false);
            playerRb.velocity = Vector3.zero;
        }
    }
}
