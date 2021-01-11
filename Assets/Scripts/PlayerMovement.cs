using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float cameraSpeed = 10.0f;
    public Vector3 Test;
    public Vector3 Test2;
    
    private Vector3 motion;
    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Moving camera with mouse
        motion = new Vector3(0, Input.GetAxisRaw("Mouse X"), 0);// Input.GetAxisRaw("Mouse Y"));
        Test = motion;
        Test2 = motion * cameraSpeed * Time.deltaTime;

        transform.Rotate(motion * cameraSpeed * Time.deltaTime);

        //Moving camera with WSAD
        //motion = new Vector3(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        //_rigidbody.velocity = motion * cameraSpeed;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float translationWS = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float translationAD = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(translationAD, 0, translationWS);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(0, 5, 0);
        }
    }
}
