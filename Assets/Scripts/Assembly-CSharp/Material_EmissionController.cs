using UnityEngine;

public class Material_EmissionController : MonoBehaviour
{
	[SerializeField]
	private bool active;

	[SerializeField]
	private Renderer rend;

	[SerializeField]
	private int indexMaterial;

	[ColorUsage(true, true)]
	[SerializeField]
	private Color colorEmission;

	private void LateUpdate()
	{
	}

	public void UpdateMaterials()
	{
	}
}
