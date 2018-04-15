using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneHealth : MonoBehaviour {

    public float maxHealth = 150;
    public float curHealth;
   
   
	// Use this for initialization
	void Start () {
        curHealth = maxHealth;
      
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(curHealth);

        DestroyBone();
	}
    public void TakeDamage(float amount)
    {
        curHealth -= amount * Time.deltaTime;
        
    }
    public void DestroyBone()
    {
        if (curHealth <= 0)
        {
            curHealth = 0;
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter()
    {

    }

    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "Drill")
        {

            TakeDamage(10);
            Debug.Log("dmage");
        }
    }
}
