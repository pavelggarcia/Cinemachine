using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    [SerializeField] private CameraManager _camManager;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Player")
        {
            _camManager.canSwitchCamera = true;
            _camManager.SetLowCamPriorities();
            _camManager._currentCamera = 1;
            _camManager.SetCurrentCamera();

        }
    }
    private void OnTriggerExit(Collider other) 
    {
       if(other.tag == "Player")
       {
        _camManager.canSwitchCamera = false;
        _camManager._currentCamera = 0;
        _camManager.SetLowCamPriorities();
        _camManager.SetCurrentCamera();
       } 
    }
}
