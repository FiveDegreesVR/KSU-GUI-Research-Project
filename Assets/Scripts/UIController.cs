using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    public GameObject VolumeTaskObj;
    public GameObject DifficultyTaskObj;
    public GameObject StartTaskObj;

    private TMP_Text VolumeText;
    private TMP_Text DifficultyText;
    private TMP_Text StartGameText;

    public GameObject VolumeUITextObj;
    private TMP_Text VolumeUIText;

    public GameObject StartGameButton;
    public GameObject VolumeSliderObj;
    private Slider VolumeSlider;
    
    public GameObject DifficultyDropdownObj;
    private TMP_Dropdown DifficultyDropdown;

    private bool volTaskComplete;
    private bool DifTaskComplete;

    // Start is called before the first frame update
    void Start()
    {
        volTaskComplete = false;
        DifTaskComplete = false;
        
        VolumeText = VolumeTaskObj.GetComponent<TMP_Text>();
        DifficultyText = DifficultyTaskObj.GetComponent<TMP_Text>();
        StartGameText = StartTaskObj.GetComponent<TMP_Text>();

        VolumeUIText = VolumeUITextObj.GetComponent<TMP_Text>();

        VolumeSlider = VolumeSliderObj.gameObject.GetComponent<Slider>();
        DifficultyDropdown = DifficultyDropdownObj.GetComponent<TMP_Dropdown>();
        
        StartGameButton.GetComponent<Button>().onClick.AddListener(UpdateStartTaskColor);
        //VolumeSlider.gameObject.GetComponent<>()
    }

    // Update is called once per frame
    void Update()
    {
        VolumeUIText.text = VolumeSlider.value + "%";
        
        if (!volTaskComplete)
        {
            if (VolumeSlider.value < 100)
            {
                VolumeText.color = Color.green;
                Debug.Log("volume task complete: " + Time.time);
                volTaskComplete = true;
            }
        }

        if (!DifTaskComplete)
        {
            if (DifficultyDropdown.value > 0)
            {
                DifficultyText.color = Color.green;
                Debug.Log("Difficulty task complete: " + Time.time);
                DifTaskComplete = true;    
            }
        }
        
        
    }

    void UpdateStartTaskColor()
    {
        StartGameText.color = Color.green;
        Debug.Log("Game Start task complete: " + Time.time);
    }
}
