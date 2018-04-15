using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic_move : MonoBehaviour {

    [SerializeField]public float speed;
	// Use this for initialization
	void Start () {
        speed = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKey("space"))
        {
            transform.Translate(0.0f, Time.deltaTime * speed * -1.0f, 0.0f);
        }

	}
}
