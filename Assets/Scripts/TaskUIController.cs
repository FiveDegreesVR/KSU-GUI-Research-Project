using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TaskUIController : MonoBehaviour
{
    [SerializeField] private GameObject VolTask;
    [SerializeField] private GameObject DiffTask;
    [SerializeField] private GameObject StartGameTask;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeVolColor()
    {
        VolTask.GetComponent<TMP_Text>().color = Color.green;
    }
    
    public void changeDiffColor()
    {
        DiffTask.GetComponent<TMP_Text>().color = Color.green;
    }
    
    public void changeStartGameColor()
    {
        StartGameTask.GetComponent<TMP_Text>().color = Color.green;
    }
}
