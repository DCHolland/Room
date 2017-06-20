using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour {
    int count;
	// Use this for initialization
	void Start () {
        count = 1;
       }

    public void Increase()
    {
        count++;
        if (count > 9)
            count = 0;
    }

    public void Decrease()
    {
        count--;
        if (count < 0)
            count = 9;
    }

    public int getCount()
    {
        return count;
    }
}
