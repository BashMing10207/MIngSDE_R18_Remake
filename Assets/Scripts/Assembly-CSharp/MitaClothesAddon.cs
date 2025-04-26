using UnityEngine;

public class MitaClothesAddon : MonoBehaviour
{
	public MitaClothesAddon_Object[] objects;

	private void Start()
	{
	}

	public bool IsMod()
	{
		return false;
	}

	private void SetMaterials(Renderer _renderer, Material[] _materials, Texture2D[] _textures)
	{
	}
}
