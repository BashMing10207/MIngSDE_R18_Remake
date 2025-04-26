using UnityEngine;

public class MakeManeken_Box : MonoBehaviour
{
	[SerializeField]
	private MakeManeken_Main main;

	private Rigidbody rb;

	private float yLimit;

	private bool hold;

	private bool animationHand;

	private float intensityRightItem;

	private Vector3 positionWas;

	private Quaternion rotationWas;

	[SerializeField]
	[Header("Мита")]
	private Transform rightItem;

	private bool firstFall;

	private AudioSource audioBox;

	[Header("Звуки")]
	[SerializeField]
	private AudioClip soundFirstFall;

	[SerializeField]
	private AudioClip soundWhoosh;

	[SerializeField]
	private AudioClip[] soundsTake;

	[SerializeField]
	private AudioClip[] soundsFall;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void TakeBox()
	{
	}

	public void DropBox()
	{
	}

	public void RestartBox()
	{
	}

	public void HideBox()
	{
	}
}
