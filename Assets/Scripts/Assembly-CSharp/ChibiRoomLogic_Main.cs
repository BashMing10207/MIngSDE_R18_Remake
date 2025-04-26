using UnityEngine;
using UnityEngine.Events;

public class ChibiRoomLogic_Main : MonoBehaviour
{
	[Header("Общее")]
	public GameObject chibiMita;

	[Header("Room")]
	public Mob_ChibiMita_Animation animationNopeKey;

	private bool cartHold;

	[Header("Цех")]
	public Transform pointCart;

	public Transform pivotCart;

	public AnimationClip animationMitaWalkCart;

	public AnimationClip animationMitaWalk;

	public UnityEvent eventWalkToCart;

	public Mob_ChibiMita_Animation animationDropCart;

	public GameObject[] irons;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void NopeKey()
	{
	}

	public void GoCart()
	{
	}

	public void CartTake()
	{
	}

	public void CartWasDrop()
	{
	}

	public void IronDestroy()
	{
	}
}
