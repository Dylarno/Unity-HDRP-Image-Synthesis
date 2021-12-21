using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSegmentationSetup : MonoBehaviour
{
    [SerializeField] private RenderTexture rt;
    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        SyncRenderTextureAspect(rt, mainCamera);
    }

    void SyncRenderTextureAspect(RenderTexture rt, Camera camera)
    {
        float aspect = rt.width / (float)rt.height;

        if (!Mathf.Approximately(aspect, camera.aspect))
        {
            rt.Release();
            rt.width = camera.pixelWidth;
            rt.height = camera.pixelHeight;
            rt.Create();
        }
    }
}
