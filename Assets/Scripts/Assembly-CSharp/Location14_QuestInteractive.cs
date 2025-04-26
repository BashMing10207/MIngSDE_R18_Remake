using EPOOutline;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Outlinable))]
public class Location14_QuestInteractive : MonoBehaviour
{
	[SerializeField]
	private Location14_GameQuestPlayer main;

	public bool active;

	public Vector3 positionMove;

	public UnityEvent eventFinishMove;

	[Header("Интерфейс")]
	[SerializeField]
	private Transform cameraTarget;

	[SerializeField]
	private Transform rectPoint;

	[SerializeField]
	private Image circle;

	[SerializeField]
	private Image alpha;

	[SerializeField]
	private Image icon;

	private bool mouse;

	private Outlinable outline;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	public void Deactivation()
	{
	}

	public void Activation()
	{
	}

	public void DestroyMe()
	{
	}
}
