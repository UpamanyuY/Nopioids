using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marking : MonoBehaviour {

    public Transform MarkPoint;

	public GameObject TheMark;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		
	
    
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Mark")
		{
			TheMark.transform.position = MarkPoint.transform.position;
		}
	}
}
