using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer_And_Sizing : MonoBehaviour
{
    private float timer = 0;

    public float offset;

    public bool isGamestarted = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            isGamestarted = true;
            
        }
        else if(Input.GetKey(KeyCode.Q))
        {
            isGamestarted = false;
        }
        
        if (isGamestarted)
        {
            float YRotate = Input.GetAxis("Horizontal");
            float XRotate = Input.GetAxis("Vertical");
            timer += Time.deltaTime;
            Debug.Log(timer);

                
            transform.localScale += new Vector3(offset, offset, offset) * Time.deltaTime;
                
            transform.Rotate(XRotate, YRotate, 0);
            
            //transform.Rotate();

        }
        else
        {
            timer = 0;
            if (transform.localScale.x > 1f)
            {
                transform.localScale -= new Vector3(offset, offset, offset) * Time.deltaTime;
            }
        }
        
        
    }
}
