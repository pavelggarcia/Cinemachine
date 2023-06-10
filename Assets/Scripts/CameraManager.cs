using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private GameObject[] _cameras;
    public int _currentCamera;
    public bool canSwitchCamera;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C) && canSwitchCamera)
        {
            _currentCamera++;
            if(_currentCamera >= _cameras.Length)
            {
                _currentCamera = 1;
            }
            SetLowCamPriorities();
            SetCurrentCamera();
        }
    }
    public void SetLowCamPriorities()
    {
        foreach(GameObject c in _cameras)
        {
            if(c.GetComponent<CinemachineVirtualCamera>())
            {
                c.GetComponent<CinemachineVirtualCamera>().Priority = 10;
            }
            if(c.GetComponent<CinemachineBlendListCamera>())
            {
                c.GetComponent<CinemachineBlendListCamera>().Priority =10;
            }
        }
    }

    public void SetCurrentCamera()
    {
        if(_cameras[_currentCamera].GetComponent<CinemachineVirtualCamera>())
        {
            _cameras[_currentCamera].GetComponent<CinemachineVirtualCamera>().Priority = 15;
        }
        if(_cameras[_currentCamera].GetComponent<CinemachineBlendListCamera>())
        {
            _cameras[_currentCamera].GetComponent<CinemachineBlendListCamera>().Priority = 15;
        }
    }
}
