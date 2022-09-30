using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HandCollissionManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("DiffDropdown"))
        {
            TouchUIController.expandDropdown();
        }
        
        if (collision.gameObject.CompareTag("StartButton"))
        {
            TouchUIController.pressStartGame();
        }

        if (TouchUIController.getDropdownStatus())
        {
            for (int i = 0; i < 4; i++)
            {
                if (collision.gameObject.CompareTag("Option" + i))
                {
                    TouchUIController.assignSelectedValue(i);
                }
            }
        }
        
    }
}
