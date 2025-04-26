using System.Collections.Generic;
using UnityEngine;

public class MitaMeshFixed : MonoBehaviour
{
	[HideInInspector]
	public List<string> normalBones;

	public SkinnedMeshRenderer[] meshes;

	[ContextMenu("Очистить")]
	private void Fix()
	{
	}
}
