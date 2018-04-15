using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drill : MonoBehaviour
{
    public float spin;


    public void Start()
    {

    }

   
    public void Update()
    {
		transform.Rotate(0, 0, spin);

        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("spinning");
            spin = 5;


        }
    }
}
   

