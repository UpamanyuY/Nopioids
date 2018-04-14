using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forcepts : MonoBehaviour {

	public bool grabbed;
	public GameObject grabobject;

	// Use this for initialization
	void Start () {
		

	}

	// Update is called once per frame
	void Update () {

		if(grabbed)
		{
			grabobject.transform.position = new Vector3 (transform.position.x, transform.position.y - .5f , transform.position.z);

			if(Input.GetButtonDown ("Fire1"))
			{
				grabobject.GetComponent<Rigidbody> ().useGravity = true;
				grabobject.GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.None;
				grabobject = null;
				grabbed = false;
			}
		}


			
	}

	void OnTriggerEnter (Collider other )
	{
		if (other.gameObject.tag == "Gunk")
		{
			grabobject = other.gameObject;
			other.GetComponent <Rigidbody> ().useGravity = false;
			other.GetComponent <Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			grabbed = true;
		}
	}

	void OnTriggerExit ()
	{
		
	}

	void OnTriggerStay()
	{
		
	}


}
