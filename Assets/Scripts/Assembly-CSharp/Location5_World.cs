using UnityEngine;
using UnityEngine.Events;

public class Location5_World : MonoBehaviour
{
	private bool mitaKnife;

	[SerializeField]
	[Header("Мита")]
	private MitaPerson mita;

	[SerializeField]
	private UnityEvent eventKnifeNearPlayer;

	[SerializeField]
	private AnimationClip animationWalkKnife;

	[SerializeField]
	private Vector3 positionStart;

	[SerializeField]
	private Transform pointMoveScreamer;

	private void Update()
	{
	}

	public void MitaKnife()
	{
	}
}
