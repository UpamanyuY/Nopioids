using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour {

    float Rot;
    public float spin;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        spin = Input.GetAxisRaw("CameraRotate");


        if (spin >= .8f)
        {
            Rot = 5;
        }
        if (spin <= .8f)
        {
            Rot = 0;
        }

        transform.Rotate(0, Rot * Time.deltaTime, 0);
        

    }
}
