using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NerveScript : MonoBehaviour {

    public Vector3 startingPosition;
    public Quaternion startPos;
    public bool pushedNerve;
    public float speed;
	// Use this for initialization
	void Start () {
        startingPosition = transform.position;
        speed = 5.0f;
        pushedNerve = false;
    }
	
	// Update is called once per frame
	void Update () {
		
        if(pushedNerve)
        {
            Vector3.Slerp(transform.position, startingPosition, Time.deltaTime*speed);
            if(transform.position == startingPosition)
            {
                pushedNerve = true;
            }
        }

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Drill")
        {
            Debug.Log("GAME OVER MAN");
        }

        if(col.gameObject.tag == "Forcepts")
        {
            Debug.Log("GAME OVER MAN");
        }

    }

    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "Shield")
        {
            pushedNerve = true;
            Debug.Log("Sheild push stopped");
        }
    }
}
