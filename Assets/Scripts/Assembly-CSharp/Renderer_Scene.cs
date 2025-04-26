using UnityEngine;

public class Renderer_Scene : MonoBehaviour
{
	[Range(0f, 100f)]
	public float speed;

	public bool active;

	[Header("Camera")]
	public Color colorCamera;

	public Camera cameraMain;

	[Header("Background")]
	public Color colorBackground;

	[Header("Fog")]
	public Color colorFog;

	public float fogStart;

	public float fogEnd;

	private void Update()
	{
	}

	public void Activation()
	{
	}
}
