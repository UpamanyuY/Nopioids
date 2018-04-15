using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedHeightScript : MonoBehaviour {

    [SerializeField] public bool BedHeightBool;
    [SerializeField] public bool Low;
    [SerializeField] public Vector3 POSITION;
    [SerializeField] public Vector3 Target1;
    [SerializeField] public Vector3 Target2;
    [SerializeField] public float Speed;

    // Use this for initialization
    void Start () {
        BedHeightBool = false;
        Target1 = transform.position;
        Target2 = Target1;
        Target2.y += 0.2f;
        Speed = 1.0f;
        Low = true;
	}
	
	// Update is called once per frame
	void Update () {
        SetBedHeight();

    }

    void SetBedHeight()
    {
        if (Input.GetKey("t"))
        {
            //0.0 to 0.2 on the Y [GLOBAL]
            if (Low)
            {
                if (transform.position == Target2)
                {
                    Low = false;
                }
                else
                {
                    transform.position = Vector3.Lerp(transform.position, Target2, Time.deltaTime * Speed);
                }
            }
        }
        if(Input.GetKey("g"))
        {
            if (transform.position == Target1)
            {
                Low = true;
            }
            else
            {
                transform.position = Vector3.Lerp(transform.position, Target1, Time.deltaTime * Speed);
            }

        }

        }

    }

