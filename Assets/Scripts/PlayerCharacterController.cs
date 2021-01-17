using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterController : MonoBehaviour
{
    private Rigidbody rb;

    public bool isGrounded;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 22 //check the int value in layer manager(User Defined starts at 8) 
            && !isGrounded)
        {
            isGrounded = true;
        }
        
        if (collision.gameObject.tag == "Player")
        {

            Debug.Log("PLAYER!!!");
            //GameObject exp = Instantiate(explosion, this.transform.position, Quaternion.identity);
            //Destroy(exp, 0.5f);
            //Destroy(this.gameObject);
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.layer == 22
            && isGrounded)
        {
            isGrounded = false;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
