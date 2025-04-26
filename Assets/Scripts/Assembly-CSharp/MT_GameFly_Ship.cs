using NaughtyAttributes;
using UnityEngine;

public class MT_GameFly_Ship : MonoBehaviour
{
	[SerializeField]
	private MT_GameFly main;

	[SerializeField]
	private bool isMita;

	private Vector3 positionLast;

	[SerializeField]
	[Header("Корабль")]
	private GameObject prefabBullet;

	[SerializeField]
	private ParticleSystem particleShot;

	[SerializeField]
	private ParticleSystem particleDamage;

	[SerializeField]
	private GameObject prefabExplode;

	private Vector2 move;

	private float timeShot;

	private GameObject ship;

	[HideInInspector]
	public float timeImmortal;

	private float visible;

	private RaycastHit hit;

	private Vector3 positionNeed;

	private Vector3 positionNeedLerp;

	private int timeCheck;

	private float moveNeed;

	private float timeRandomPosition;

	[Header("Управление Миты")]
	[SerializeField]
	private LayerMask layerEnemy;

	private bool win;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Shot()
	{
	}

	public void Damage()
	{
	}

	[Button("Взорвать корабль", EButtonEnableMode.Always)]
	public void Explode()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public void Win()
	{
	}

	private void CheckMita()
	{
	}

	private void NeedMoveFromEnemy(Vector3 _position)
	{
	}
}
