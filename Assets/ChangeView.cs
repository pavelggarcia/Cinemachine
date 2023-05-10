using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ChangeView : MonoBehaviour
{
    private CinemachineVirtualCamera _cam;
    private GameObject[] _shapes;
    private int _shapeLookAt = 0;
    private int _FOV = 60;
    
    // Start is called before the first frame update
    void Start()
    {
        _cam = GetComponent<CinemachineVirtualCamera>();
        _shapes = GameObject.FindGameObjectsWithTag("Shape");

    }

    // Update is called once per frame
    void Update()
    {
        ChangeLookAt();
        CycleFOV();
    }
    private void ChangeLookAt()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            _cam.LookAt = _shapes[_shapeLookAt].transform;
            _shapeLookAt +=1;
        }
        if(_shapeLookAt == _shapes.Length)
        {
            _shapeLookAt = 0;
        }
    }
    private void CycleFOV()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _cam.m_Lens.FieldOfView = _FOV;
            _FOV -= 20;
        }
        if(_FOV < 20)
        {
            _FOV = 60;
        }
    }
}
