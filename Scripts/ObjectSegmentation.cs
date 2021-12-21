using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

public class ObjectSegmentationCustomPass : ObjectIDCustomPass
{
    protected override bool executeInSceneView => false;
}
