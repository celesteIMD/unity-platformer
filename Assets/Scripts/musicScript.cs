using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicScript : MonoBehaviour
{
    public AudioSource music;
    public float timeLeft;
    
    // Start is called before the first frame update
    void Start()
    {
        music = GetComponent<AudioSource>();
        music.pitch = 1.0f;
        
        timeLeft = 40f;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 10.0f)
        {
            music.pitch = 2.0f;
        }
    }
}
