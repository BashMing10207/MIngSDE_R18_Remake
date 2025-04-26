using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(ObjectAnimationPlayer))]
public class ObjectAnimationPlayerHold : MonoBehaviour
{
	[Header("Анимация")]
	public AnimationClip animationHold;

	[SerializeField]
	private AnimationHoldOtherAnimator[] otherAnimatons;

	[SerializeField]
	private UnityEvent eventReady;

	[SerializeField]
	private UnityEvent eventHold;

	[SerializeField]
	private UnityEvent eventStopHold;

	[SerializeField]
	private UnityEvent eventDown;

	private Vector2 previousDirection;

	private float totalAngle;

	[Range(0f, 1f)]
	[SerializeField]
	[Header("Управление")]
	private float keyForward;

	[SerializeField]
	private float speedForward;

	[SerializeField]
	private float speedBack;

	[SerializeField]
	private bool hold;

	[SerializeField]
	private string key;

	[Range(-1f, 1f)]
	[SerializeField]
	private int mouseRotate;

	[Header("Звуки")]
	[SerializeField]
	private AudioSource audioHold;

	[HideInInspector]
	public float animationTimeHold;

	private float animationTimeHoldNow;

	private float timeAddKey;

	private bool ready;

	private bool holdMove;

	private PlayerMove scrpm;

	private ObjectAnimationPlayer scroap;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Restart()
	{
	}

	private void AnimationDown()
	{
	}

	private void Ready()
	{
	}

	private void MoveMouse()
	{
	}
}
