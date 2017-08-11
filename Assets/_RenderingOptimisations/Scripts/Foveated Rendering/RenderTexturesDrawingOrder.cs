using UnityEngine;
using System.Collections;

public class RenderTexturesDrawingOrder : MonoBehaviour
{	//This class draws all the render textures at an order specified here. If you want to combine multiple instances of this gameobject to implement things like stereoscopy or multiscopy you need to disable this and use the render textures as you please.
    [Tooltip("Outer Layer")]
	public RenderTexture outerTexture;
    [Tooltip("Middle Layer")]
    public RenderTexture middleTexture;
    [Tooltip("Inner Layer")]
	public RenderTexture innerTexture;

	public UpdateViewport innerViewport;

	public RenderTexture finalTexture;

    void OnGUI()
    {
		RenderTexture.active = finalTexture;
		GL.PushMatrix();
        if (Event.current.type.Equals(EventType.Repaint))//only draw once a frame
        {
			Graphics.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), outerTexture);
            Graphics.DrawTexture(new Rect(innerViewport.focusPoint.x - (Screen.height * 0.4f / 2), Screen.height - innerViewport.focusPoint.y - (Screen.height * 0.4f / 2), Screen.height * 0.4f, Screen.height * 0.4f), middleTexture);
            Graphics.DrawTexture(new Rect(innerViewport.focusPoint.x - (Screen.height * 0.2f / 2), Screen.height - innerViewport.focusPoint.y - (Screen.height * 0.2f / 2), Screen.height * 0.2f, Screen.height * 0.2f), innerTexture);
        }

		GL.PopMatrix();
		RenderTexture.active = null;
    }

}

