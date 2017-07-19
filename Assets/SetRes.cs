using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRes : MonoBehaviour {

	int aa = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.A))
		{
			if(aa == 0)
				QualitySettings.antiAliasing = aa = 8;
			else
				QualitySettings.antiAliasing = aa = 0;
		}
	}

    void OnPreRender()
    {
        Screen.SetResolution(640, 480, true);
    }
}
