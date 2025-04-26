using UnityEngine;
using UnityEngine.Events;

public class Location17_Coffee : MonoBehaviour
{
	private bool waterReady;

	private bool water;

	[Header("Вода")]
	[SerializeField]
	private RectTransform rectWater;

	[SerializeField]
	private RectTransform rectWaterPos;

	[SerializeField]
	private LayerMask layerDefaultWater;

	[SerializeField]
	private AudioSource audioWater;

	private bool teapotControl;

	private PlayerPersonIK scrppik;

	private Transform handRightPlayer;

	private bool waterGo;

	private float timeWater;

	[Header("Управление чайником")]
	[SerializeField]
	private Transform targetTeapotControl;

	[SerializeField]
	private ParticleSystem particleWater;

	[SerializeField]
	private ParticleSystem particleWaterAddone;

	[SerializeField]
	private Transform waterForTeapot;

	[SerializeField]
	private AudioSource audioWaterInside;

	[SerializeField]
	private UnityEvent eventReadyTeapotWater;

	private bool coffeeRotateReady;

	private float timeRotate;

	[SerializeField]
	[Header("Кофе")]
	private SpriteRenderer spriteCoffeeRotate;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public void Water(bool x)
	{
	}

	public void TeapotWater()
	{
	}

	public void CoffeeRotate()
	{
	}

	public void ReadyCoffeeRotate()
	{
	}
}
