using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeDoor : MonoBehaviour {
    bool rot;
    bool startRot;
    public Transform pivot;
	// Use this for initialization
	void Start () {
        rot = false;
        startRot = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (startRot)
        {
            if(transform.rotation.z >=.4)
            transform.RotateAround(pivot.transform.position,Vector3.up, 5);
        }
	}

    void OnCollisionEnter(Collision other) {
        if (other.collider.CompareTag("Key"))
            {
                if (!rot)
                {
                    rot = true;
                startRot = true;
                }
             }
    }

}
