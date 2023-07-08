using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

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

        

        if (Input.GetKey(KeyCode.Q))
        {
            isGamestarted = false;
        }



        if (isGamestarted)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                transform.localScale += new Vector3(offset, offset, offset) * Time.deltaTime;
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                transform.DOScale(new Vector3(1, 1, 1), 1f);
            }
        }
        
        
        if (isGamestarted)
        {
            float YRotate = Input.GetAxis("Horizontal");
            float XRotate = Input.GetAxis("Vertical");
            timer += Time.deltaTime;
            Debug.Log(timer);
            transform.Rotate(XRotate, YRotate, 0);

            //transform.Rotate();
        }
        else
        {
            timer = 0;
        }
    }
}