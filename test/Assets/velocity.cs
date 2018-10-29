using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class velocity : MonoBehaviour {
	private float speed = 3.0f;	
	// Use this or initialization
	void Start () {
	this.GetComponent<Rigidbody>().AddForce(
            (transform.right) * speed,
            ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
