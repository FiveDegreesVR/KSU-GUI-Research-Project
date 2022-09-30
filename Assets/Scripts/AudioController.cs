using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    private AudioSource audioSource;
    public GameObject audioSliderObj;
    private Slider audioSlider;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSlider = audioSliderObj.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        audioSource.volume = audioSlider.value / 100;
    }
}
