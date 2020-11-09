using UnityEngine;

[RequireComponent( typeof( MeshRenderer ) )]
public class Cube : MonoBehaviour
{
    private static readonly int _shaderProperty = Shader.PropertyToID("_Color");
    private MaterialPropertyBlock _mpb;
    public MaterialPropertyBlock Mpb
    {
        get
        {
            if( _mpb == null )
            {
                _mpb = new MaterialPropertyBlock();
            }
            return _mpb;
        }
    }

    public MeshRenderer MeshRenderer => GetComponent<MeshRenderer>();
    
    public void ChangeColor( Color col )
    {
        Mpb.SetColor( _shaderProperty, col );
        MeshRenderer.SetPropertyBlock( Mpb );
    }

    public void ChangeToRandomColor()
    {
        Color[] colors = { Color.red, Color.blue, Color.green };
        Color col = colors[ Random.Range(0, colors.Length )];
        ChangeColor( col );
    }
}
