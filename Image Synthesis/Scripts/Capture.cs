using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Capture : MonoBehaviour
{
    // public RenderTexture rt;
    public RawImage rawImage;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            SaveTextureAsPNG(TextureToTexture2D(rawImage.texture));
        }
    }

    private Texture2D TextureToTexture2D(Texture texture)
    {
        Texture2D texture2D = new Texture2D(texture.width, texture.height, TextureFormat.RGBA32, false);
        RenderTexture currentRT = RenderTexture.active;
        RenderTexture renderTexture = RenderTexture.GetTemporary(texture.width, texture.height, 32);
        Graphics.Blit(texture, renderTexture);

        RenderTexture.active = renderTexture;
        texture2D.ReadPixels(new Rect(0, 0, renderTexture.width, renderTexture.height), 0, 0);
        texture2D.Apply();

        RenderTexture.active = currentRT;
        RenderTexture.ReleaseTemporary(renderTexture);
        return texture2D;
    }

    private void SaveTextureAsPNG(Texture2D _texture)
    {
        byte[] _bytes = _texture.EncodeToPNG();
        File.WriteAllBytes("Capture.png", _bytes);
    }
}
