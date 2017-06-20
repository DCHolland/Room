using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuner : MonoBehaviour {
	AudioSource audio1;
	AudioSource audio2;
	AudioSource audio3;
	float initialX;
    public Transform left;
    public Transform right;


    // Use this for initialization
    void Start () {
		var audiosources = GetComponents<AudioSource> ();
		audio1 = audiosources [0];
		audio2 = audiosources [1];
		audio3 = audiosources [2];
		initialX = transform.position.x;

	}

	// Update is called once per frame
	void Update () {
        if(Mathf.Abs(right.position.x - transform.position.x)  < .06 && Mathf.Abs(right.position.y - transform.position.y) < .06 && Mathf.Abs(right.position.z - transform.position.z) < .1 && (Input.GetAxis("Grab2") !=0 ))
        {
            Vector3 position = transform.position;
            position.x = right.transform.position.x;
            transform.position = position;
        }

        if (Mathf.Abs(left.position.x - transform.position.x) < .06 && Mathf.Abs(left.position.y - transform.position.y) < .06 && Mathf.Abs(left.position.z - transform.position.z) < .1 && (Input.GetAxis("Grab") != 0))
        {
            Vector3 position = transform.position;
            position.x = left.transform.position.x;
            transform.position = position;
        }


        if (Input.GetKey (KeyCode.RightArrow)){
                Vector3 position = new Vector3();
                position = transform.position;
                position.x = position.x - .0004f;
                transform.position = position;
            
        }

		if (Input.GetKey (KeyCode.LeftArrow) && transform.position.x <initialX){
			Vector3 position = new Vector3();
			position = transform.position;
			position.x = position.x + .0004f;
			transform.position = position;
		}

        

		float relativeX = transform.position.x;

		float x = transform.position.x;
		audio1.volume = .7f * (1.0f + Mathf.Cos(70*x + 35.6f));
        //-(x+.8)^2 + 1
        //8 is the position of the slider where we want the thing to work

        audio2.volume = -(Mathf.Abs(20 * (x - .4333f)))+1;
        audio3.volume = -(Mathf.Abs(40* (x-.34f)))+1;

      if (transform.position.x < .311f)
      {
          transform.position = new Vector3(.311f, transform.position.y, transform.position.z);
      }

      if (transform.position.x > .497)
      {
            transform.position = new Vector3(.497f, transform.position.y, transform.position.z);
      }

      if (x == .497f)
      {
            audio1.volume=0;
            audio2.volume=0;
            audio3.volume=0;
      }
    }
}
