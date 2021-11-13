using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;

public class PlayerCamera : MonoBehaviour
{
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseY = Input.GetAxis("Mouse Y") * 2;
        float MouseY = Mathf.Clamp(mouseY, -90.0f, 90.0f);
        
        
        transform.Rotate(Vector3.left* MouseY * 0.5f);
        
    }
}
