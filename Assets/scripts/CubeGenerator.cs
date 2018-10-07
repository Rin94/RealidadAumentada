using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour {

    public GameObject cubo;

	// Use this for initialization
	void Start () {
        //Instantiate(cubo, transform.position, transform.rotation);
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyUp(KeyCode.Space))
        {
            GameObject ob= Instantiate(cubo, transform.position, transform.rotation) as GameObject;
            Destroy(ob, 3f);
        }
    }
}
