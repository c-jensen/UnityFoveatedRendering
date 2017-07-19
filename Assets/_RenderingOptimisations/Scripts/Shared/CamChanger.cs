using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamChanger : MonoBehaviour {

	[Tooltip("Camera with Postprocessing")]
	public Camera withPost;
	[Tooltip("Camera without Postprocessing")]
	public Camera withoutPost;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.O))
		{
			withPost.gameObject.SetActive (true);
			withoutPost.gameObject.SetActive (false);
		}
		if(Input.GetKeyDown(KeyCode.L))
		{
			withPost.gameObject.SetActive (false);
			withoutPost.gameObject.SetActive (true);
		}
	}
}
