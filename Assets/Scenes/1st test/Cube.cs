using Sirenix.OdinInspector;
using Sirenix.Utilities.Editor;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Cube : MonoBehaviour
{
    #region scale
    [Header("S C A L E")]
    public float From = 2, To = 7;

    [CustomValueDrawer("MyCustomDrawerInstance")][OnValueChanged("ChangeScale")]
    public float CustomDrawerInstance;

    private float MyCustomDrawerInstance(float value, GUIContent label)
    {
        return EditorGUILayout.Slider(label, value, this.From, this.To);
    }


    void ChangeScale()
    {
        transform.localScale = new Vector3(CustomDrawerInstance, CustomDrawerInstance, CustomDrawerInstance);
    }
    #endregion

    #region color
    [Space(10)][Header("C O L O R")]
    [ColorPalette][OnValueChanged("ChangeColor")]
    public Color ColorOptions;

    void ChangeColor()
    {
        GetComponent<MeshRenderer>().sharedMaterial.color = ColorOptions;
    }

    #endregion
}
