using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Newgrab : MonoBehaviour
{

    [SerializeField]
    OVRInput.Controller controller;

    [SerializeField]
    string buttonName;

    [SerializeField]
    float grabRadius;

    [SerializeField]
    LayerMask grabMask;

    private GameObject grabbedObject;
    public bool grabbing;

    private Quaternion LastRoation, currentRotation;



    // Use this for initialization
    void Start()
    {

        grabbing = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (grabbedObject != null)
        {
            LastRoation = currentRotation;
            currentRotation = grabbedObject.transform.rotation;
        }

        if (!grabbing && (Input.GetAxis(buttonName) == 1)) { GrabObject(); print("toggled bool true"); }
        if (grabbing && (Input.GetAxis(buttonName) < 1)) { DropObject(); print("toggled bool false"); }
    }

    void GrabObject()
    {
        grabbing = true;

        RaycastHit[] hits;

        hits = Physics.SphereCastAll(transform.position, grabRadius, transform.forward, 0f, grabMask);

        if (hits.Length > 0)
        {
            int closestHit = 0;

            for (int i = 0; i < hits.Length; i++)
            {
                if (hits[i].distance < hits[closestHit].distance) closestHit = 1;
            }

            grabbedObject = hits[closestHit].transform.gameObject;
            grabbedObject.GetComponent<Rigidbody>().isKinematic = true;
            grabbedObject.transform.position = transform.position;
            grabbedObject.transform.parent = transform;
        }
    }

    void DropObject()
    {
        grabbing = false;

        if (grabbedObject != null)
        {
            grabbedObject.transform.parent = null;
            grabbedObject.GetComponent<Rigidbody>().isKinematic = false;
            //grabbedObject.GetComponent<Rigidbody>().useGravity = true;

            grabbedObject.GetComponent<Rigidbody>().velocity = OVRInput.GetLocalControllerVelocity(controller);
            grabbedObject.GetComponent<Rigidbody>().angularVelocity = GetAngularVelocity();

            grabbedObject = null;
        }
    }

    Vector3 GetAngularVelocity()
    {
        Quaternion deltaRotation = currentRotation * Quaternion.Inverse(LastRoation);
        return new Vector3(Mathf.DeltaAngle(0, deltaRotation.eulerAngles.x), Mathf.DeltaAngle(0, deltaRotation.eulerAngles.y), Mathf.DeltaAngle(0, deltaRotation.eulerAngles.z));
    }
}