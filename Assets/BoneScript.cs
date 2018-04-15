using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "Drill")
        {
            Debug.Log("Drilling! OUCH!");
        }

        if(collision.gameObject.tag == "Forcepts")
        {
            Debug.Log("Forcepts for drilling? Why?");
        }
    }
}
