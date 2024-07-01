using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PairObjectData", menuName = "ScriptableObjects/SpawnPairObject", order = 1)]
public class PairObjectSO : ScriptableObject
{
    public List<PairObjects> pairobjectlist;
}

[System.Serializable]
public class PairObjects
{
    public int id;
    public Sprite pairimage;
}
