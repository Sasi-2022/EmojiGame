
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class ObjectMatchingForm : MonoBehaviour
{
    [SerializeField] private int matchId;

    public int Get_ID()
    {
        return matchId;
    }
}
