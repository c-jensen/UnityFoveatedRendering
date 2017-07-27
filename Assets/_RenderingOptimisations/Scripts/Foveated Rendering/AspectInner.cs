using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AspectInner : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Camera>().aspect = 1;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
