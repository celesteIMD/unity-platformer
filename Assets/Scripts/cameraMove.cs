using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Vector3 = System.Numerics.Vector3;

public class cameraMove : MonoBehaviour
{
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float newXPosition = player.transform.position.x;

        transform.position = new Vector3(newXPosition, transform.position.y, transform.position.z);
    }
}
