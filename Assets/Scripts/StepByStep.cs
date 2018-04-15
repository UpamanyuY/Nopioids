using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepByStep : MonoBehaviour {

    int Steps;
    GameObject CurTool;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        switch (Steps)
        {
            case 1:

             
                break;

            case 2:

                
                break;

            case 3:

               
                break;

            case 4:

               
                break;

            case 5:
              
                break;

            case 6:
               
                break;

            case 7:
                
                break;

            case 8:
               
                break;


            //Needle
            default:
                
                break;

        }
    }

    void OnTriggerEnter(Collider other)
    {
        //CurTool = other.gameObject;

        //Needle
        if (other.gameObject.layer == 8)
        {

        }

        if (other.gameObject.layer == 9)
        {

        }

        if (other.gameObject.layer == 10)
        {

        }

        if (other.gameObject.layer == 11)
        {

        }

        if (other.gameObject.layer == 12)
        {

        }

        if (other.gameObject.layer == 13)
        {

        }


        if (other.gameObject.layer == 14)
        {

        }

        if (other.gameObject.layer == 15)
        {

        }
    }

}
