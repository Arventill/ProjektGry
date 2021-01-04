using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float mouseSens = 5000f;
    public Transform playerBody;

    private float _vRotation = 0f;
    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        float translationWS = Input.GetAxis("Vertical") * speed;
        float translationAD = Input.GetAxis("Horizontal") * speed;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(0, 5, 0);
        }
        float rotation = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;

        // Make it move 10 meters per second instead of 10 meters per frame...
        translationWS *= Time.deltaTime;
        translationAD *= Time.deltaTime;
        rotation *= Time.deltaTime;

        // Move translation along the object's z-axis
        transform.Translate(translationAD, 0, translationWS);

        // Rotate around our y-axis
        transform.Rotate(0, rotation, 0);
    }
}
