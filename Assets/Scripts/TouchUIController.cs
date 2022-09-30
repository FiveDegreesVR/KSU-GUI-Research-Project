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

    public GameObject dropdownCollidersObj;
    private static GameObject dropdownColliders;

    // Start is called before the first frame update
    void Start()
    {
        DifficultyDropdown = DifficultyDropdownObj.GetComponent<TMP_Dropdown>();
        startButton = startButtonObj.GetComponent<Button>();
        dropdownColliders = dropdownCollidersObj;
        dropdownColliders.SetActive(false);
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
            dropdownColliders.SetActive(true);
            
        }
        else
        {
            DifficultyDropdown.Hide();
            dropdownColliders.SetActive(false);
        }
    }

    public static bool getDropdownStatus()
    {
        return DifficultyDropdown.IsExpanded;
    }

    public static void pressStartGame()
    {
        //TRIGGER COLOR CHANGE FOR TASK
    }

    public static void assignSelectedValue(int option)
    {
        DifficultyDropdown.value = option;
        DifficultyDropdown.Hide();
        dropdownColliders.SetActive(false);
    }
}
