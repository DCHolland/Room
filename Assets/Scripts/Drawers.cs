using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawers : MonoBehaviour
{

    public Transform left;
    public Transform right;
    float zinitial;

    // Use this for initialization
    void Start()
    {
        zinitial = transform.position.z;
    }

    // Update is called once per frame
    void LateUpdate()
    {
     

        if (Mathf.Abs(right.position.x - transform.position.x) < 1 && Mathf.Abs(right.position.y - transform.position.y) < .2 && Mathf.Abs(right.position.z - transform.position.z) < 1 && (Input.GetAxis("Grab2") != 0))
        {
            Vector3 position = transform.position;
            position.z = right.transform.position.z;
            transform.position = left.position;
        }

        if (Mathf.Abs(left.position.x - transform.position.x) < 1 && Mathf.Abs(left.position.y - transform.position.y) < .2 && Mathf.Abs(left.position.z - transform.position.z) < 1 && (Input.GetAxis("Grab") != 0))
        {
            Vector3 position = transform.position;
            position.z = left.transform.position.z;
            transform.position = left.position;
        }




        if (transform.position.z < zinitial)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zinitial);
        }

        if (transform.position.z > zinitial + .15f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zinitial+.15f);
        }
    }
}
