using System.Collections.Generic;
using UnityEngine;

public class CoreScreens : MonoBehaviour
{
	[SerializeField]
	private bool onlyBlink;

	[SerializeField]
	private GameObject mainScreen;

	private bool showMonitors;

	private int indexShow;

	private float timeShowNext;

	private List<GameObject> monitors;

	[SerializeField]
	[Header("Мониторы")]
	private Vector3[] addonPosition;

	[SerializeField]
	private Vector3[] addonRotation;

	[SerializeField]
	private Vector3[] addonScaleMirror;

	[SerializeField]
	private Vector2[] addonScaleRect;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ShowScreens(bool x)
	{
	}
}
