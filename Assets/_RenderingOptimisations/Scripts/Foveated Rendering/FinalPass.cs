using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPass : MonoBehaviour {

    public RenderTexture finalRenderTexture;

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(finalRenderTexture, destination);
    }
}
