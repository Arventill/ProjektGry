using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float y = 0.0f;
    public float TestCamPlusY;
    public float actualRotation;
    public float cameraSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        y = -1 * Input.GetAxisRaw("Mouse Y") * cameraSpeed * Time.deltaTime;
        
        TestCamPlusY = transform.rotation.x + y;
        actualRotation = this.transform.rotation.x;
        


        //if (transform.rotation.x + y > 0.40f && transform.rotation.x + y < -0.30f)
        {
            transform.Rotate(y, 0, 0);
        }
    }
}
