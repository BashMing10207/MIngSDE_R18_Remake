using System.Collections.Generic;
using UnityEngine;

public class Unity_CheckBonesMesh : MonoBehaviour
{
	public SkinnedMeshRenderer meshA;

	public Transform[] bonesA;

	public SkinnedMeshRenderer meshB;

	public Transform[] bonesB;

	public bool checkNames;

	public bool meshACopymeshB;

	public bool justUpdate;

	public bool destroyEmptyBones;

	[Space(20f)]
	public bool applyA;

	public Transform[] applyNewBonesForA;

	public Transform findNamesTransform;

	[HideInInspector]
	public List<Transform> bonesNew;

	private void OnValidate()
	{
	}
}
