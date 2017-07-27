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
			Graphics.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), outerTexture);     //if the render texture is from the whole screen draw the render texture full screen

            //if not, draw it appropriately for foveated rendering at the right size and location.
            Graphics.DrawTexture(new Rect(innerViewport.focusPoint.x - (middleTexture.width / 2), Screen.height - innerViewport.focusPoint.y - (middleTexture.height / 2), middleTexture.width, middleTexture.height), middleTexture);
            Graphics.DrawTexture(new Rect(innerViewport.focusPoint.x - (innerTexture.width/2), Screen.height - innerViewport.focusPoint.y - (innerTexture.height/2), innerTexture.width, innerTexture.height), innerTexture);
		}

		GL.PopMatrix();
		RenderTexture.active = null;
    }

}

