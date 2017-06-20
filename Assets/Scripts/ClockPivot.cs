using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockPivot : MonoBehaviour {
    public Transform hour;
    public Transform minute;
    bool rot;
	// Use this for initialization
	void Start () {
        rot = false;
	}
	
	// Update is called once per frame
	void Update () {
     //   print(minute.transform.rotation.z);
       // print(hour.transform.rotation.z);
        if (Mathf.Abs(hour.transform.eulerAngles.z) <10 && Mathf.Abs(minute.transform.eulerAngles.z - 90.0f) < 10 && Input.GetAxis("Grab") == 0 && Input.GetAxis("Grab2") ==0)
        {
             minute.GetComponent<BoxCollider>().enabled = false;
             hour.GetComponent<BoxCollider>().enabled = false;
            rot = true;
        }

        if (rot)
        {
            if (transform.rotation.y < 1)
                transform.Rotate(0, 1, 0);
        }
	}



}
