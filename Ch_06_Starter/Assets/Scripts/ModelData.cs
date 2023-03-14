using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Model Data", menuName = "ScriptableObjects/Model Data")]
public class ModelData : ScriptableObject
{
    public PrimitiveType primitiveType;
    public Vector3 position;
    public Vector3 rotation;
    public Vector3 scale;
}

public class Utilities
{
    public static GameObject CreateFromSO(string name)
    {
        ModelData data = Resources.Load(name) as ModelData;

        GameObject go = GameObject.CreatePrimitive(data.primitiveType);
        go.name = data.name;
        go.transform.localScale = data.scale;
        go.transform.localPosition = data.position;
        go.transform.localRotation = Quaternion.Euler(data.rotation);

        MeshRenderer renderer = go.GetComponent<MeshRenderer>();
        renderer.material.color = Color.gray;

        return go;
    }
}