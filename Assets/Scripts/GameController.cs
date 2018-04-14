using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject Drill;

    public GameObject Forcept;

    public bool IsActive;

	// Use this for initialization
	void Start () {

        Drill = GameObject.Find("Drill");

        Forcept = GameObject.Find("Forcept");
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Switch"))
        {
            if (IsActive)
            {
                GoActive();
            }
            else
            {
                NotActive();
            }
        }


    }

    public void GoActive ()
    {
        IsActive = false;
        Forcept.SetActive(true);
        Drill.SetActive(false);
    }

    public void NotActive ()
    {
        IsActive = true;
        Drill.SetActive(true);
        Forcept.SetActive(false);
    }
}
