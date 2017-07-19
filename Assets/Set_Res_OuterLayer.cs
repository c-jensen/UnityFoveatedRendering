using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set_Res_OuterLayer : MonoBehaviour {

    private int x = 0;

    public Camera renderCam;

    void Update()
    {
        if(x % 2 == 0)
            renderCam.enabled = true;
        else
            renderCam.enabled = false;
        x++;
    }

    void OnPostRender()
    {
        renderCam.enabled = false;
    }
}
