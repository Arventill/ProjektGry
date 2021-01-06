using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limits : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Set the hinge limits for a door.
        HingeJoint hinge = GetComponent<HingeJoint>();

        JointLimits limits = hinge.limits;
        limits.min = -86;
        limits.bounciness = 0;
        limits.bounceMinVelocity = 0;
        limits.max = 130;
        hinge.limits = limits;
        hinge.useLimits = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
