using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Character : MonoBehaviour
{
    [SerializeField] private CharacterController _controller;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotateSpeed;
    private Vector3 _direction;
    private CinemachineVirtualCamera _vcam;
    private GameObject[] _vcams;


    // Start is called before the first frame update
    void Start()
    {
        _vcam = GetComponent<CinemachineVirtualCamera>();
        _vcams = GameObject.FindGameObjectsWithTag("VCamera");
        _vcams[0].SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        float _horizontal = Input.GetAxis("Horizontal");
        float _vertical = Input.GetAxis("Vertical");
        _direction = new Vector3(0, 0, _vertical);
        _direction *= _moveSpeed * Time.deltaTime;
        _controller.Move(_direction);

        Vector3 rotation = new Vector3(0, _horizontal * _rotateSpeed * Time.deltaTime, 0);
        this.transform.Rotate(rotation);

       ActivateOrbitalCam();
    }

    void ActivateOrbitalCam()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _vcams[0].SetActive(true);
        }
        else if (Input.GetMouseButtonUp(1))
        {
            _vcams[0].SetActive(false);
        }
    }
}