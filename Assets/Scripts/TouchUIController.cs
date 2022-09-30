using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TouchUIController : MonoBehaviour
{
    public GameObject startButtonObj;
    public GameObject DifficultyDropdownObj;

    private static TMP_Dropdown DifficultyDropdown;
    private static Button startButton;
    
    // Start is called before the first frame update
    void Start()
    {
        DifficultyDropdown = DifficultyDropdownObj.GetComponent<TMP_Dropdown>();
        startButton = startButtonObj.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void expandDropdown()
    {
        if (!DifficultyDropdown.IsExpanded)
        {
            DifficultyDropdown.Show();
        }
        else
        {
            DifficultyDropdown.Hide();
        }
    }

    public static void pressStartGame()
    {
        //TRIGGER COLOR CHANGE FOR TASK
    }
}
