using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent( typeof( MeshRenderer ) )]
public class Cube : MonoBehaviour
{
    public MeshRenderer MeshRenderer => GetComponent<MeshRenderer>();

    public void ChangeColor( Color col )
    {
        MeshRenderer.material.color = col;
    }

    public void ChangeToRandomColor()
    {
        Color[] colors = { Color.red, Color.blue, Color.green };
        Color col = colors[ Random.Range(0, colors.Length )];
        ChangeColor( col );
    }
}
