using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physics : MonoBehaviour {

    public float speed=10f;

    //GameObject cubo = GameObject.Find("Cube");
    //Rigidbody rg;
    // Use this for initialization
    //Rigidbody rg = GetComponent<Rigidbody>();
	void Start () {
    // Rigidbody.AddForce(Vector3.forward);
        //rg.AddForce(new Vector3(1f, 0f, 1f), ForceMode.Impulse);
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Translate(Vector3.forward*speed*Time.deltaTime/2);
		
	}
}
