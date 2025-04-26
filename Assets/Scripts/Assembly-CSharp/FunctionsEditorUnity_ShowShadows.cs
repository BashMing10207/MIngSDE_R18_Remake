using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

public class FunctionsEditorUnity_ShowShadows : MonoBehaviour
{
	private List<GameObject> rendes;

	private float alphaLines;

	private bool sideAlphaLine;

	[SerializeField]
	private bool showUnity;

	[SerializeField]
	private Color gizmosColor;

	[Button("Обновить", EButtonEnableMode.Always)]
	private void UpdateRenderers()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
