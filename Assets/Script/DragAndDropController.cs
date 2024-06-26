using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropController : MonoBehaviour
{
    public GameObject item;
    public GameObject itemDrop;

    public int dis;

    Vector2 itemPos;

    private void Start()
    {
        itemPos = item.transform.localPosition;
    }

    public void ItemDrag()
    {
        item.transform.position = Input.mousePosition;
    }

    public void ItemEndDrag()
    {
        float distance = Vector3.Distance(item.transform.localPosition, itemDrop.transform.localPosition);
        if(distance < dis)
        {
            item.transform.localPosition = itemDrop.transform.localPosition;
        }
        else
        {
            item.transform.localPosition = itemPos;
        }
    }
}
