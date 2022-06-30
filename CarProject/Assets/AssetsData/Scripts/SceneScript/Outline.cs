using UnityEngine;
/// <summary>
/// ��߸���������Ϣ��
/// </summary>
public class Outline
{
    public Renderer Renderer { get; set; }
    public SkinnedMeshRenderer SkinnedMeshRenderer { get; set; }
    public MeshFilter MeshFilter { get; set; }

    public int color;
    public bool eraseRenderer;

    private Material[] _SharedMaterials;
    public Material[] SharedMaterials
    {
        get
        {
            if (_SharedMaterials == null)
                _SharedMaterials = Renderer.sharedMaterials;

            return _SharedMaterials;
        }
    }
}