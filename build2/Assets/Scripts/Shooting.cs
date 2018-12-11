using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    Rigidbody2D myRigitbody;
    public float movespeed;
	// Use this for initialization
	void Start () {
        myRigitbody = GetComponent<Rigidbody2D>();
        
        myRigitbody.AddRelativeForce(Vector2.right * movespeed, ForceMode2D.Impulse);
	}

	
	void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
	
}
