using NaughtyAttributes;
using UnityEngine;

public class Location21_DialogueRandom : MonoBehaviour
{
	[Label("Диалоги")]
	[SerializeField]
	private GameObject[] dialogues;

	[Label("Удалить (this) после")]
	[SerializeField]
	private bool destroyAfter;

	public void ChangeRandom()
	{
	}

	public void ChangeRandomDestroyOther()
	{
	}
}
