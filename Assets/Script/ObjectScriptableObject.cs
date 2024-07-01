using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ObjectData", menuName = "ScriptableObjects/SpawnObject", order = 1)]
public class ObjectScriptableObject : ScriptableObject
{
    public List<Objects> objectlist;
}

[System.Serializable]
public class Objects
{
    public int id;
    public Sprite image;
}
