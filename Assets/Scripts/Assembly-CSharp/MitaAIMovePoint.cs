using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;

public class MitaAIMovePoint : MonoBehaviour
{
	[SerializeField]
	[Label("Мита")]
	private MitaPerson mita;

	[SerializeField]
	[Label("Ходьба")]
	private AnimationClip animationWalkMita;

	[Label("Цель")]
	[SerializeField]
	private Transform targetMove;

	[Label("Примагнитить")]
	public bool magnetAfter;

	[Label("Отключить IK на старте")]
	[SerializeField]
	private bool diactiveIKPlayer;

	[Label("Дошли до точки")]
	[SerializeField]
	[Header("События")]
	private UnityEvent eventFinish;

	[Label("Отправляемся к точке")]
	[SerializeField]
	private UnityEvent eventStart;

	[SerializeField]
	[Label("Если уже рядом")]
	private float distanceMinStart;

	public void PlaySharply()
	{
	}

	[Button("Play", EButtonEnableMode.Always)]
	public void Play()
	{
	}

	public void PlayRotateAndWalk()
	{
	}
}
