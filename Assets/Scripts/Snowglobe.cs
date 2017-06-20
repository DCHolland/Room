using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowglobe : MonoBehaviour {

	public GameObject shard;
	public GameObject snowBase;
	public GameObject key;
	Vector3 last;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void lateUpdate()
	{
		last = transform.position;
	}
	void OnCollisionEnter(Collision other)
	{
		if (other.relativeVelocity.magnitude >= 5) {
				key.transform.parent = null;
				key.GetComponent<BoxCollider> ().enabled = true;
                key.GetComponent<Rigidbody>().isKinematic = false;
                snowBase.transform.parent = null;
                snowBase.GetComponent<BoxCollider>().enabled = true;
                snowBase.GetComponent<Rigidbody>().isKinematic = false;
                snowBase.GetComponent<AudioSource>().Play();

            foreach (Transform child in transform)
            {
                if (child.CompareTag("Shard"))
                {
                    child.transform.parent = null;
                    child.GetComponent<BoxCollider>().enabled = true;
                    child.GetComponent<Rigidbody>().isKinematic = false;
                    child.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-10,10),Random.Range(-10,10),Random.Range(-10,10)));
                }
            }
			Destroy (gameObject);
		}
	}
}
