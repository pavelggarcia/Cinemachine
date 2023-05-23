using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraSwitcher : MonoBehaviour
{
    private GameObject[] _vcams;
    // Start is called before the first frame update
    void Start()
    {
        _vcams = GameObject.FindGameObjectsWithTag("VCamera");
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(this.gameObject.name == "Cube1")
        {
            foreach(GameObject VC in _vcams)
            {
                if(VC.name == "cam02")
                {
                    VC.GetComponent<CinemachineVirtualCamera>().m_Priority = 15;
                }
            }
        } else if(this.gameObject.name == "Cube2")
        {
            foreach(GameObject VC in _vcams)
            {
                if(VC.name == "cam03")
                {
                    VC.GetComponent<CinemachineVirtualCamera>().m_Priority = 15;
                }
            }
        } else if(this.gameObject.name == "Cube3")
        {
            foreach(GameObject VC in _vcams)
            {
                if(VC.name == "cam04")
                {
                    VC.GetComponent<CinemachineVirtualCamera>().m_Priority = 15;
                }
            }
        } else if(this.gameObject.name == "Cube4")
        {
            foreach(GameObject VC in _vcams)
            {
                if(VC.name == "cam01")
                {
                    VC.GetComponent<CinemachineVirtualCamera>().m_Priority = 15;
                }
            }
        }
    }
    private void OnTriggerExit(Collider other) 
    {
        foreach(GameObject VC in _vcams)
        {
            VC.GetComponent<CinemachineVirtualCamera>().m_Priority = 10;
        }    
    }
}
