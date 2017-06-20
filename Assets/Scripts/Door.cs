using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
    public Lock lock1;
    public Lock lock2;
    public Lock lock3;
    public Transform pivot;
    bool rot;
    // Use this for initialization
    void Start () {
        rot = false;
	}
	
	// Update is called once per frame
	void Update () {


        // if (lock1.transform.eulerAngles.x== 0 && lock2.transform.eulerAngles.x == 288 && lock3.transform.eulerAngles.x == 288)
        if (lock1.getCount() ==5 && lock2.getCount() ==3 && lock3.getCount() ==8)
            rot = true;
        if (rot)
        {
            if (transform.rotation.y >= -.8)
                transform.RotateAround(pivot.transform.position, Vector3.up, -.2f);
        }
    }
}
