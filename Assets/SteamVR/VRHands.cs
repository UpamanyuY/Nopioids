using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VRHands : MonoBehaviour {

    Forcepts grab;
    private Valve.VR.EVRButtonId gripbutton = Valve.VR.EVRButtonId.k_EButton_Grip;
    public bool gripButtonDown = false;
    public bool gripButtonUp = false;
    public bool gripButtonPressed = false;

    private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;
    public bool triggerButtonDown = false;
    public bool triggerButtonUp = false;
    public bool triggerButtonPressed = false;

    Vector3 RHand;
    Vector3 LHand;

    private SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObj.index); } }
    private SteamVR_TrackedObject trackedObj;
    // Use this for initialization
    void Start() {
        grab = GetComponent<Forcepts>();
        trackedObj = GetComponent<SteamVR_TrackedObject>();

        RHand = GameObject.Find("Controller (right)").transform.localPosition;
        LHand = GameObject.Find("Controller (left)").transform.localPosition;
    }

        // Update is called once per frame
        void Update () {
        Controls();

    }

    void Controls()
    {
        if (controller == null)
        {
            Debug.Log("Controller not initialized");

            return;
        }
        gripButtonDown = controller.GetPressDown(gripbutton);
        gripButtonUp = controller.GetPressUp(gripbutton);
        gripButtonPressed = controller.GetPress(gripbutton);

        triggerButtonDown = controller.GetPressDown(triggerButton);
        triggerButtonUp = controller.GetPressUp(triggerButton);
        triggerButtonPressed = controller.GetPress(triggerButton);

        if (gripButtonDown)
        {
            Debug.Log("Grip Button was just pressed");
        }

        if (gripButtonUp)
        {
            Debug.Log("Grip Button was just unpressed");
        }

        if (triggerButtonDown)
        {
            Debug.Log("Trigger Button was just pressed");
        }

        if (triggerButtonUp)
        {
            Debug.Log("Trigger Button was just unpressed");
        }
    }

     void OnTriggerStay(Collider other)
    {
        if(other.tag == "Gunk" && triggerButtonPressed)
        {
            Debug.Log("We are IN");
            grab.Grab();
        }
    }
}
