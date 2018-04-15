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
            //GuideWire
            case 1:
             
                break;

            //Scalpel
            case 2:
                
                break;

            //Dilator
            case 3:
               
                break;

            //Canula
            case 4:
               
                break;

            //Endoscope
            case 5:
              
                break;

            //Tool
            case 6:
               
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
            Steps += 1;
        }

        //GuideWire
        if (other.gameObject.layer == 9)
        {

        }

        //Scalpel
        if (other.gameObject.layer == 10)
        {

        }

        //Dilator
        if (other.gameObject.layer == 11)
        {

        }

        //Canula
        if (other.gameObject.layer == 12)
        {

        }

        //Endoscope
        if (other.gameObject.layer == 13)
        {

        }

        //Tool
        if (other.gameObject.layer == 14)
        {

        }
    }

}
