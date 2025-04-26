using UnityEngine;
using UnityEngine.Events;

public class Location34_Glasses : MonoBehaviour
{
	public static bool glassesMita;

	[SerializeField]
	private Transform_Magnet glassesMagnet;

	[Header("Локация 4")]
	[SerializeField]
	private GameObject glassesGameCard;

	[SerializeField]
	private bool location4;

	[SerializeField]
	private UnityEvent eventAnimationDropGlass;

	private float timeTetrisDialogue;

	private bool activeTetris;

	[SerializeField]
	[Header("Тетрис")]
	private GameObject dialogueTetris;

	[SerializeField]
	private Location34_Communication communication;

	private GameController scrgc;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void TakeGlasses()
	{
	}

	public void TakeDropGlasses()
	{
	}

	public void StartDropGlasses()
	{
	}

	public void TetrisActivation(bool x)
	{
	}
}
