using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AspectFullScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Camera>().aspect = (float)Screen.width / (float)Screen.height;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
