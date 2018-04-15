using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drill : MonoBehaviour
{
    BoneHealth health; 
    public float spin;


    public void Start()
    {
        health = GameObject.Find("Bone").GetComponent<BoneHealth>();

    }

    void OnCollisionStay(Collision collision)
    {
        if (gameObject.tag == ("Bone"))
        {

            health.TakeDamage(10);
        }
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
   

