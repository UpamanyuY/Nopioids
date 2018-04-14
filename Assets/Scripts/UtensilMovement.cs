using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtensilMovement : MonoBehaviour {

	public bool Disabled;

	public float HSpeed;

	public float ZSpeed;

	public float YSpeed;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(!Disabled)
		{
			var x = Input.GetAxis ("Horizontal") * Time.deltaTime * HSpeed;

			var z = Input.GetAxis ("Vertical") * Time.deltaTime * ZSpeed;

			var y = Input.GetAxis ("Vertical2") * Time.deltaTime * YSpeed;

			transform.Rotate (z, 0, -x);
			transform.Translate (0, y, 0);
		}


		
	}
}
