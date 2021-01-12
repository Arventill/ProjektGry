using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private float totalY = 0f;
    public float y = 0.0f;
    public float cameraSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = new Quaternion(0,0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        y = -1 * Input.GetAxisRaw("Mouse Y") * cameraSpeed * Time.deltaTime;
        
        if (totalY + y < 40f && totalY + y > -60f)
        {
            transform.Rotate(y, 0, 0);
            totalY += y;
        }
    }
}
