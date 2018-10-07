using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movimiento : MonoBehaviour {

    private int direccion = 0;
    public float moveSpeed = 0.05f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        switch(direccion){
            case 1:
                transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
                break;
            case 2:
                transform.Translate(Vector3.back*moveSpeed * Time.deltaTime);
                break;
            case 3:
                transform.Translate(Vector3.left *moveSpeed * Time.deltaTime);
                break;

            case 4:
                transform.Translate(Vector3.right * moveSpeed * Time.deltaTime / 2);
                break;

            case 5:
                transform.Translate(Vector3.up * moveSpeed * Time.deltaTime / 2);
                break;


            case 6:
                transform.Translate(Vector3.down * moveSpeed * Time.deltaTime / 2);
                break;


            default:
                break;
        }
		
	}

    public void move(int direccion)
    {
        this.direccion = direccion;

    }
}
