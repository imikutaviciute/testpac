﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Rendering.Universal;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UIElements;

[CustomEditorForRenderPipeline(typeof(Camera), typeof(UniversalRenderPipelineAsset))]
[CanEditMultipleObjects]
public class CustomPackageCameraEditor : UniversalRenderPipelineCameraEditor 
{
    public override void OnInspectorGUI()
    {
        EditorGUILayout.LabelField("asrdf");
    }

    public override VisualElement CreateInspectorGUI()
    {
        return new VisualElement();
    }
}
