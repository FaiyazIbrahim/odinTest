// TableMatrixExamplesComponent.cs
using Sirenix.OdinInspector;
using UnityEngine;

#if UNITY_EDITOR // Editor namespaces can only be used in the editor.
using Sirenix.OdinInspector.Editor.Examples;
#endif

public class TableMatrixExamplesComponent : SerializedMonoBehaviour
{

    [TableMatrix(SquareCells = true)]
    [OnValueChanged("ObjectChange")]
    public Mesh[,] PrefabMatrix;


#if UNITY_EDITOR // Editor-related code must be excluded from builds
    [OnInspectorInit]
    private void CreateData()
    {
        PrefabMatrix = new Mesh[8, 4]
        {
            { ExampleHelper.GetMesh(), null, null, null },
            { null, ExampleHelper.GetMesh(), null, null },
            { null, null, ExampleHelper.GetMesh(), null },
            { null, null, null, ExampleHelper.GetMesh() },
            { null, null, null, ExampleHelper.GetMesh() },
            { null, null, ExampleHelper.GetMesh(), null },
            { null, ExampleHelper.GetMesh(), null, null },
            { ExampleHelper.GetMesh(), null, null, null },
        };
    }

    private void ObjectChange()
    {

    }
#endif
}