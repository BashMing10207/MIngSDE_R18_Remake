using NaughtyAttributes;
using UnityEngine;

public class Unity_SkinnedMeshEditor : MonoBehaviour
{
	[SerializeField]
	private SkinnedMeshRenderer mesh;

	[SerializeField]
	private Transform[] bones;

	[Header("Другой меш, для просмотра")]
	[SerializeField]
	private SkinnedMeshRenderer meshCheck;

	[SerializeField]
	private Transform[] meshCheckBones;

	[Button("Найти все кости", EButtonEnableMode.Always)]
	private void FindAllBones()
	{
	}

	[Button("Принять новые изменения", EButtonEnableMode.Always)]
	private void AplyNewBones()
	{
	}

	private void OnValidate()
	{
	}
}
