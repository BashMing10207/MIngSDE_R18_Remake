using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;

public class Location15 : MonoBehaviour
{
	[Header("Мита-Манекен")]
	[SerializeField]
	private SkinnedMeshRenderer rendFace;

	[SerializeField]
	private Mesh meshFaceManeken;

	[SerializeField]
	private Material materialFaceManeken;

	[SerializeField]
	private UnityEvent eventRechangeFace;

	[Button("Сменить кожу", EButtonEnableMode.Always)]
	public void RechangeFace()
	{
	}
}
