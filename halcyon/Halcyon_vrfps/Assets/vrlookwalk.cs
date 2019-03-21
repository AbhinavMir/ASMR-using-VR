using UnityEngine;
using System.Collections;

public class VRLookWalk : MonoBehaviour
{
    public Transform vrCamera;
    public float toggleAngle = 30.0f;
    public float speed = 3.0f;
    public bool moveForward;
    private CharacterController cc;

    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    private void Update()
    {
        {
            if(vrCamera.eulerAngles.x>=toggleAngle && vrCamera.eulerAngles.x < 90.0f) //Between 30 degrees and 90 degrees
            {
                moveForward = true;
            }
            else
            {
                moveForward = false;
            }

            if (moveForward)
            {

                new Vector3 forward = vrCamera.TransformDirection(new Vector3.forward);
                cc.SimpleMove(forward * speed);
            }
        }
    }
}