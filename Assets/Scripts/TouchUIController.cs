using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


//i know this code sucks but im tired 
public class TouchUIController : MonoBehaviour
{
    public GameObject startButtonObj;
    public GameObject DifficultyDropdownObj;

    private static TMP_Dropdown DifficultyDropdown;
    private static Button startButton;

    public GameObject dropdownCollidersObj;
    private static GameObject dropdownColliders;

    AudioSource audioManager;
    private static int audioSource;

    public GameObject volumeLabelObj;
    private TMP_Text volumeLabel;
    private static BoxCollider dropdownMainCollide;
    
    public GameObject VolumeTaskObj;
    public GameObject DifficultyTaskObj;
    public GameObject StartTaskObj;

    private bool volumeTaskDone;
    private bool difficultyTaskDone;
    private bool startTaskDone;

    private static bool startButtonPressed;
    private static bool dropdownButtonPressed;
    private static bool volumeButtonPressed;

    // Start is called before the first frame update
    void Start()
    {
        DifficultyDropdown = DifficultyDropdownObj.GetComponent<TMP_Dropdown>();
        startButton = startButtonObj.GetComponent<Button>();
        dropdownColliders = dropdownCollidersObj;
        audioManager = GetComponent<AudioSource>();
        volumeLabel = volumeLabelObj.GetComponent<TMP_Text>();
        dropdownColliders.SetActive(false);
        dropdownMainCollide = DifficultyDropdown.GetComponent<BoxCollider>();

        audioSource = 100;

        volumeTaskDone = false;
        difficultyTaskDone = false;
        startTaskDone = false;

        startButtonPressed = false;
        dropdownButtonPressed = false;
        volumeButtonPressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        volumeLabel.text = audioSource + "%";
        audioManager.volume = ((float)audioSource / 100);
        //Debug.Log(audioSource);

        if (startButtonPressed)
        {
            startGameTaskComplete();
        }

        if (dropdownButtonPressed)
        {
            difficultyTaskComplete();
        }

        if (volumeButtonPressed)
        {
            volumeTaskComplete();
        }
    }

    public static void expandDropdown()
    {
        if (!DifficultyDropdown.IsExpanded)
        {
            DifficultyDropdown.Show();
            dropdownColliders.SetActive(true);
            dropdownMainCollide.enabled = false;
        }
        /*
        else
        {
            DifficultyDropdown.Hide();
            dropdownColliders.SetActive(false);
        }
        */
    }

    public static bool getDropdownStatus()
    {
        return DifficultyDropdown.IsExpanded;
    }

    public static void pressStartGame()
    {
        startButtonPressed = true;
    }

    public static void assignSelectedValue(int option)
    {
        DifficultyDropdown.value = option;
        DifficultyDropdown.Hide();
        dropdownColliders.SetActive(false);
        dropdownMainCollide.enabled = true;
        dropdownButtonPressed = true;
    }
    
    public static void volumeUp()
    {
        //TMP_Text volumeText = volumeLabel.GetComponent<TMP_Text>();
        
        if (audioSource <  100)
        {
            audioSource += 10;
            //volumeText.text = (audioSource * 100) + "%";
            volumeButtonPressed = true;
        }
    }
    
    public static void volumeDown()
    {
        //TMP_Text volumeText = volumeLabel.GetComponent<TMP_Text>();
        
        if (audioSource >  0)
        {
            audioSource -= 10;
            //volumeText.text = (audioSource * 100) + "%";
            volumeButtonPressed = true;
        }
    }

    void volumeTaskComplete()
    {
        if (!volumeTaskDone)
        {
            VolumeTaskObj.GetComponent<TMP_Text>().color = Color.green;
            Debug.Log("Volume task complete: " + Time.time);
            volumeTaskDone = true;
        }
    }

    void difficultyTaskComplete()
    {
        if (!difficultyTaskDone)
        {
            DifficultyTaskObj.GetComponent<TMP_Text>().color = Color.green;
            Debug.Log("Difficulty task complete: " + Time.time);
            difficultyTaskDone = true;
        }
    }

    void startGameTaskComplete()
    {
        if (!startTaskDone)
        {
            StartTaskObj.GetComponent<TMP_Text>().color = Color.green;
            Debug.Log("Start Game task complete: " + Time.time);
            startTaskDone = true;
        }
    }
}
