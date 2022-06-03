using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class Spawn : MonoBehaviour
{

    [HideLabel]
    [OnValueChanged("SpawnObject")]
    [PreviewField(50, ObjectFieldAlignment.Right)]
    [HorizontalGroup("row1", 50), VerticalGroup("row1/right")]
    //public Object obj;
    public GameObject obj;

    void SpawnObject()
    {
        Instantiate(obj,transform.parent);
        obj.transform.position = transform.position;
        
    }
}
