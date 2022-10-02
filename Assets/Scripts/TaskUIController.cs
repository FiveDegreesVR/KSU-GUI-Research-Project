using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TaskUIController : MonoBehaviour
{
    [SerializeField] private GameObject VolTask;
    [SerializeField] private GameObject DiffTask;
    [SerializeField] private GameObject StartGameTask;

    private bool volTaskDone;
    private bool diffTaskDone;
    private bool startGameTaskDone;
    
    // Start is called before the first frame update
    void Start()
    {
        volTaskDone = false;
        diffTaskDone = false;
        startGameTaskDone = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeVolColor()
    {
        if (!volTaskDone)
        {
            VolTask.GetComponent<TMP_Text>().color = Color.green;
            Debug.Log("Volume task complete: " + Time.time);
            volTaskDone = true;
        }
    }
    
    public void changeDiffColor()
    {
        if (!diffTaskDone)
        {
            DiffTask.GetComponent<TMP_Text>().color = Color.green;
            Debug.Log("Difficulty task complete: " + Time.time);
            diffTaskDone = true;
        }
    }
    
    public void changeStartGameColor()
    {
        if (!startGameTaskDone)
        {
            StartGameTask.GetComponent<TMP_Text>().color = Color.green;
            Debug.Log("Start Game task complete: " + Time.time);
            startGameTaskDone = true;
        }
    }
}
