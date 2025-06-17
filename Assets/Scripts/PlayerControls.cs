using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float jumpForce;
    public float moveForce;
    public Rigidbody2D rb;
    private bool canJump;

    void Start()
    {
        canJump = true;
    }

    // Update is called once per frame
    void Update()
    {
        //WASD, arrows, and space bar inputs
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            if (canJump == true)
            {
                rb.AddForce(Vector2.up * jumpForce);
                StartCoroutine(CoolDown());
            }
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector2.left * moveForce);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector2.right * moveForce);
        }
        
    }
    
    private IEnumerator CoolDown()
    {
        canJump = false;
        yield return new WaitForSeconds(2);
        canJump = true;
    }
}
