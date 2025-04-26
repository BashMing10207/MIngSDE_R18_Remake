using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;

public class Location10_GameAutomate : MonoBehaviour
{
	[SerializeField]
	private GameObject[] objectsActive;

	[SerializeField]
	private GameObject[] objectsDestroy;

	[SerializeField]
	private Transform positionAnimationPlay;

	[SerializeField]
	private ObjectDoor doorCorridor;

	[SerializeField]
	private UnityEvent eventFinish;

	[Button("Финишировать игру", EButtonEnableMode.Always)]
	public void FinishGame()
	{
	}
}
