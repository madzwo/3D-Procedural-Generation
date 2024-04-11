using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapDisplay : MonoBehaviour
{
    public Renderer textureRender;

    public void DrawTexture(Texture2D texture)
    {
        textureRender.sharedMaterial.SetTexture("_MainTex", texture);
        textureRender.transform.localScale = new Vector3(texture.width, 1f, texture.height);
    }

}
