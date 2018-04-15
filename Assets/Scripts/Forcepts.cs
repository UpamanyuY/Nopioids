using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forcepts : MonoBehaviour {

	public bool grabbed;
	public GameObject grabobject;

	public float RaycastLength;
	public float clampfloat;

	// Use this for initialization
	void Start () {
		

	}

	// Update is called once per frame
	void Update () {

        Grab();
	
	}

    public void Grab()
    {
        clampfloat = Input.GetAxisRaw("Grab");
        if (clampfloat >= .8f)
        {
            RaycastLength = 50;
        }

        if (grabbed)
        {
            grabobject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);


            if (clampfloat <= .8)
            {
                if (grabobject != null)
                {
                   // Destroy(grabobject);
                    grabobject = null;
                }
            }

            /*if(Input.GetButtonDown ("Fire1"))
			{
				grabobject.GetComponent<Rigidbody> ().useGravity = true;
				grabobject.GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.None;
				grabobject = null;
				grabbed = false;
				RaycastLength = 0;
			}*/
        }



        Vector3 forward = transform.TransformDirection(Vector3.down) * 100;
        Debug.DrawRay(transform.position, forward, Color.green);

        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, RaycastLength))
        {
            if (hit.transform.tag == "Gunk")
            {
                Debug.Log(hit.transform.tag);
                grabobject = hit.transform.gameObject;
                hit.transform.GetComponent<Rigidbody>().useGravity = false;
                hit.transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                grabbed = true;
            }

        }
    }






    /*void OnTriggerEnter (Collider other )
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
		
	}*/
}
