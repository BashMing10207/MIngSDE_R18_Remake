using UnityEngine;

public class Location19_Game3_Place : MonoBehaviour
{
	private Location19_GlitchGame mainRoot;

	private Location19_Game3 main;

	private bool active;

	private bool cast;

	private SpriteRenderer spr;

	[HideInInspector]
	public int index;

	[HideInInspector]
	public int indexPlanet;

	[SerializeField]
	private Transform cameraT;

	public void StartComponent(Location19_GlitchGame _mainRoot, Location19_Game3 _main, int _indexPlanet, int _indexPlace)
	{
	}

	private void Update()
	{
	}

	public void Activation(bool x)
	{
	}
}
