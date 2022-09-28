using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandPresence : MonoBehaviour
{
    private List<InputDevice> devices;
    public List<GameObject> controllerPrefabs;
    //public bool showController = false;
    public GameObject handModelPrefab;
    public InputDeviceCharacteristics controllerCharacteristics;
    
    private InputDevice targetDevice;
    private GameObject spawnedHandModel;
    
    // Start is called before the first frame update
    void Start()
    {
        devices = new List<InputDevice>();
        InputDevices.GetDevices(devices);

        spawnedHandModel = Instantiate(handModelPrefab, transform);

        foreach (var item in devices)
        {
            Debug.Log(item.name + item.characteristics);
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (devices.Count  >= 0)
        {
            InputDevices.GetDevices(devices);

            targetDevice = devices[0];
            GameObject prefab = controllerPrefabs.Find(controller => controller.name == targetDevice.name);

            if (prefab)
            {
                spawnedController = Instantiate(prefab, transform);
            }
            else
            {
                Debug.LogError("did not find corresponding controller model");
                spawnedController = Instantiate(controllerPrefabs[10], transform);
            }
        }
        */
        
        

        if (targetDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonValue) && primaryButtonValue == true)
        {
            Debug.Log("pressing primary button");
        }
        
        if (targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue) && triggerValue > 0.1f)
        {
            Debug.Log("trigger pressed: " + triggerValue);
        }
        
        if (targetDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 primary2DAxisValue) && primary2DAxisValue != Vector2.zero)
        {
            Debug.Log("primary touchpad: " + primary2DAxisValue);
        }
    }
}
