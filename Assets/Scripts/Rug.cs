using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rug : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
            transform.position = new Vector3(transform.position.x, .005f, transform.position.z);
        transform.rotation = Quaternion.Euler(0,0,0);
	}
}
