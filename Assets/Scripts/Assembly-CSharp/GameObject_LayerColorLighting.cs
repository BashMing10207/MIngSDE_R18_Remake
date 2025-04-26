using UnityEngine;

public class GameObject_LayerColorLighting : MonoBehaviour
{
	[Range(0f, 1f)]
	public float border;

	public int layerLight;

	public int layerDark;

	private void OnEnable()
	{
	}
}
