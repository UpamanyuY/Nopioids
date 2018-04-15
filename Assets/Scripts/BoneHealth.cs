using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneHealth : MonoBehaviour {

    public int maxHealth = 150;
    public int curHealth;
   
   
	// Use this for initialization
	void Start () {
        curHealth = maxHealth;
      
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(curHealth);
	}
    public void TakeDamage(int amount)
    {
        curHealth -= amount;
        
    }
    public void DestroyBone()
    {
        if (curHealth <= 0)
        {
            curHealth = 0;
            Destroy(this.gameObject);
        }
    }
}
