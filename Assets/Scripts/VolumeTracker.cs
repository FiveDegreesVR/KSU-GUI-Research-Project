using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VolumeTracker : MonoBehaviour
{
    private float volume;
    
    public GameObject audioController;
    private AudioSource audioSource;
    
    [SerializeField] private GameObject volumeTextObj;
    private TMP_Text volumeText;
    
    [SerializeField] private GameObject volTaskObj;
    private TMP_Text volTask;

    private bool volTaskComplete;
    private TaskUIController taskUI;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = audioController.GetComponent<AudioSource>();
        volumeText = volumeTextObj.GetComponent<TMP_Text>();
        volTask = volTaskObj.GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        volume = transform.position.z + 0.7f;
        audioSource.volume = volume;

        if (!volTaskComplete && volume < 0.95f)
        {
            volTaskComplete = true;
            volTask.color = Color.green;
            Debug.Log("Volume task complete: " + Time.time);
        }

        volumeText.text = "Volume: " + (int)(volume*100) + "%";
    }
}
