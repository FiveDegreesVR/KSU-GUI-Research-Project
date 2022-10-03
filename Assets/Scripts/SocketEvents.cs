using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using TMPro;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketEvents : MonoBehaviour
{
    private XRSocketInteractor socket;
    private bool startGameTaskComplete;
    [SerializeField] private GameObject startGameTaskObj;
    private TMP_Text startGameTask;

    // Start is called before the first frame update
    void Awake()
    {
        socket = gameObject.GetComponent<XRSocketInteractor>();
        socket.onSelectEntered.AddListener(taskComplete);
        startGameTask = startGameTaskObj.GetComponent<TMP_Text>();
    }

    public void taskComplete(XRBaseInteractable obj)
    {
        //Debug.Log("yep:" + obj.gameObject.tag);
    }

    public void consoleButtonPressed()
    {
        if (socket.hasSelection && !startGameTaskComplete)
        {
            startGameTask.color = Color.green;
            Debug.Log("Start Game task complete: " + Time.time);
            startGameTaskComplete = true;
        }
    }
}
