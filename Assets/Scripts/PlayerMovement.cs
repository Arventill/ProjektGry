using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public AudioSource audioSnowRunning;
    public AudioSource audioCityRunning;

    public Camera cam1;
    public Camera cam2;
    public float speedOrigin = 5f;
    public float speedUp = 0.0f;
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
        cam1.enabled = false;
    }

    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0f || Input.GetAxis("Vertical") != 0f)
        {
            //audioSnowRunning.Play();
        }

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
        if (Input.GetButton("SpeedUp") && speedUp == 0f)
        {
            speedUp = speedOrigin * Time.deltaTime;
        }
        else
        {
            speedUp = 0.0f;
        }

        float translationWS = Input.GetAxis("Vertical") * speedOrigin * Time.deltaTime;
        float translationAD = Input.GetAxis("Horizontal") * speedOrigin * Time.deltaTime;
        transform.Translate(translationAD, 0, translationWS + speedUp);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //transform.Translate(0, 500 * Time.deltaTime, 0);
            _rigidbody.velocity = Vector3.up * 5;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            cam1.enabled = !cam1.enabled;
            cam2.enabled = !cam2.enabled;
        }
    }
}
