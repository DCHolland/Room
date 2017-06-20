using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDown : MonoBehaviour
{
    public int UpOrDown;
    public Transform Lock;
    bool isDownRight;
    bool isDownLeft;
    public Transform left;
    public Transform right;
    public Lock l;

    void Start()
    {
        isDownLeft = false;
        isDownRight = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Grab2") != 0  && Mathf.Abs(right.position.x - transform.position.x) < .2 && Mathf.Abs(right.position.y - transform.position.y) < .2 && Mathf.Abs(right.position.z - transform.position.z) < .2)
        {
            if (!isDownRight )
            {
                if (UpOrDown == 1)
                {
                    Lock.Rotate(-36, 0, 0);
                    l.Increase();
                }
                else
                {
                    Lock.Rotate(36, 0, 0);
                    l.Decrease();
                }

            }
       }
        if (Input.GetAxis("Grab2") != 0)
            isDownRight = true;
        if (Input.GetAxis("Grab2") == 0)
            isDownRight = false;


        if (Input.GetAxis("Grab") != 0 && Mathf.Abs(left.position.x - transform.position.x) < .2 && Mathf.Abs(left.position.y - transform.position.y) < .2 && Mathf.Abs(left.position.z - transform.position.z) < .2)
        {
            if (!isDownLeft)
            {
                if (UpOrDown == 1)
                    Lock.Rotate(-36, 0, 0);
                else
                    Lock.Rotate(36, 0, 0);

            }
        }
        if (Input.GetAxis("Grab") != 0)
            isDownLeft = true;
        if (Input.GetAxis("Grab") == 0)
            isDownLeft = false;





    }
}
