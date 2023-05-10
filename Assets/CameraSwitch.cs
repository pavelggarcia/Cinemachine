using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    private GameObject[] _vCameras;
    private int _current =0;
    // Start is called before the first frame update
    void Start()
    {
        _vCameras = GameObject.FindGameObjectsWithTag("VCamera");
    }

    // Update is called once per frame
    void Update()
    {
        SwitchCamera();
    }

    private void SwitchCamera()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            if(_current < _vCameras.Length)
            {
                _vCameras[_current].SetActive(false);
                _current += 1;
            }
            if(_current == _vCameras.Length)
            {
                _current = 0;
                foreach(GameObject VC in _vCameras)
                {
                    VC.SetActive(true);
                }
            }
        }
    }
}
