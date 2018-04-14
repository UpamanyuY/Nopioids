using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drill : MonoBehaviour {

    public float spin;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(0, spin, 0);

        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("spinning");
            spin = 5;
        }
	}
}
