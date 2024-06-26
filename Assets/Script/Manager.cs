using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject emoji1, emoji2, emoji3, emoji4, emoji1Black, emoji2Black, emoji3Black, emoji4Black;

    Vector2 emoji1Pos, emoji2Pos, emoji3Pos, emoji4Pos;

    private void Start()
    {
        emoji1Pos = emoji1.transform.position;
        emoji2Pos = emoji2.transform.position;
        emoji3Pos = emoji3.transform.position;
        emoji4Pos = emoji4.transform.position;
    }

    public void Dragemji1()
    {
        emoji1.transform.position = Input.mousePosition;
    }
    public void Dragemji2()
    {
        emoji2.transform.position = Input.mousePosition;
    }
    public void Dragemji3()
    {
        emoji3.transform.position = Input.mousePosition;
    }
    public void Dragemji4()
    {
        emoji4.transform.position = Input.mousePosition;
    }


    public void DropEmoji1()
    {
        float Distance = Vector3.Distance(emoji1.transform.position, emoji1Black.transform.position);
        if (Distance < 50)
        {
            emoji1.transform.position = emoji1Black.transform.position;
        }
        else
        {
            emoji1.transform.position = emoji1Pos;
        }
    }
    public void DropEmoji2()
    {
        float Distance = Vector3.Distance(emoji2.transform.position, emoji2Black.transform.position);
        if (Distance < 50)
        {
            emoji2.transform.position = emoji2Black.transform.position;
        }
        else
        {
            emoji2.transform.position = emoji2Pos;
        }
    }
    public void DropEmoji3()
    {
        float Distance = Vector3.Distance(emoji3.transform.position, emoji3Black.transform.position);
        if (Distance < 50)
        {
            emoji3.transform.position = emoji3Black.transform.position;
        }
        else
        {
            emoji3.transform.position = emoji3Pos;
        }
    }
    public void DropEmoji4()
    {
        float Distance = Vector3.Distance(emoji4.transform.position, emoji4Black.transform.position);
        if (Distance < 50)
        {
            emoji4.transform.position = emoji4Black.transform.position;
        }
        else
        {
            emoji4.transform.position = emoji4Pos;
        }
    }
}
